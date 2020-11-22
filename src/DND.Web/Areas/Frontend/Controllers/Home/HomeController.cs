using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.Alerts;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using AspNetCore.Mvc.Extensions.Data.RepositoryFileSystem;
using AspNetCore.Mvc.Extensions.Email;
using AspNetCore.Mvc.Extensions.Features;
using AspNetCore.Mvc.Extensions.Helpers;
using AspNetCore.Mvc.Extensions.Mapping;
using AspNetCore.Mvc.Extensions.Services;
using AspNetCore.Mvc.Extensions.UI;
using AspNetCore.Specification.UI;
using AutoMapper;
using DND.Application;
using DND.Application.Blog;
using DND.Application.Blog.BlogPosts.Dtos;
using DND.Application.Blog.Categories.Dtos;
using DND.Application.Blog.Locations.Dtos;
using DND.Application.Blog.Locations.Services;
using DND.Application.Blog.Tags.Dtos;
using DND.Application.CMS.MailingLists.Dtos;
using DND.Application.CMS.MailingLists.Services;
using DND.Web.Areas.Frontend.Controllers.Blog;
using DND.Web.Areas.Frontend.Controllers.Countries;
using DND.Web.Areas.Frontend.Controllers.Home.Models;
using DND.Web.Areas.Frontend.Controllers.Locations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.Home
{
    [Area("Frontend")]
    [Route("")]
    //[LogAction]
    public class HomeController : MvcControllerHomeBase
    {
        private IBlogApplicationService _blogService;
        private ILocationApplicationService _locationService;
        private readonly IFileSystemGenericRepositoryFactory _fileSystemGenericRepositoryFactory;
        private readonly IMailingListApplicationService _mailingListService;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public HomeController(ControllerServicesContext context, IBlogApplicationService blogService, ILocationApplicationService locationService, IFileSystemGenericRepositoryFactory fileSystemGenericRepositoryFactory, IMapper mapper, IEmailService emailService, IMailingListApplicationService mailingListService, IWebHostEnvironment hostingEnvironment, JsonNavigationService navigationService)
            : base(context, navigationService)
        {
            if (blogService == null) throw new ArgumentNullException("blogService");
            _blogService = blogService;
            _locationService = locationService;
            _fileSystemGenericRepositoryFactory = fileSystemGenericRepositoryFactory;
            _mailingListService = mailingListService;
            _hostingEnvironment = hostingEnvironment;
        }

        [ResponseCache(CacheProfileName = "Cache24HourNoParams")]
        [Route("")] //Specifies that this is the default action for the entire application. Route: /
        public IActionResult Index()
        {
            //Validate ViewModel
            if (ModelState.IsValid)
            {
                try
                {

                }
                catch
                {
                    return HandleReadException();
                }
            }
            return View();
        }

        [HttpPost]
        [Route("")]
        public IActionResult Index(MailingListDto dto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _mailingListService.Create(dto, Username);
                    return View("Index").WithSuccess(this, "Thankyou, your subscription was successful.");
                }
                catch (Exception ex)
                {
                    HandleUpdateException(ex);
                }
            }
            //error
            return View("Index", dto);
        }

        [FeatureGate(FeatureFlags.Contact)]
        [ResponseCache(CacheProfileName = "Cache24HourNoParams")]
        [Route("contact")]
        public ActionResult Contact()
        {
            return View();
        }

        [FeatureGate(FeatureFlags.WorkWithMe)]
        [ResponseCache(CacheProfileName = "Cache24HourNoParams")]
        [Route("work-with-me")]
        public ActionResult WorkWithMe()
        {
            ViewBag.Message = "Your application description page.";
            var u = Username;

            return View();
        }

        [FeatureGate(FeatureFlags.MyWebsite)]
        [ResponseCache(CacheProfileName = "Cache24HourNoParams")]
        [Route("my-website")]
        public ActionResult MyWebsite()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [FeatureGate(FeatureFlags.About)]
        [ResponseCache(CacheProfileName = "Cache24HourNoParams")]
        [Route("about")]
        public ActionResult About()
        {
            // ResponseCachingCustomMiddleware.ClearResponseCache();
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [FeatureGate(FeatureFlags.Resume)]
        [ResponseCache(CacheProfileName = "Cache24HourNoParams")]
        [Route("resume")]
        public ActionResult Resume()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [FeatureGate(FeatureFlags.HelpFAQ)]
        [ResponseCache(CacheProfileName = "Cache24HourNoParams")]
        [Route("help-faq")]
        public ActionResult HelpFAQ()
        {
            ViewBag.Message = @"Your Help\FAQ page.";

            return View();
        }

        [FeatureGate(FeatureFlags.PrivacyPolicy)]
        [ResponseCache(CacheProfileName = "Cache24HourNoParams")]
        [Route("privacy-policy")]
        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        [FeatureGate(FeatureFlags.Contact)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("contact")]
        public async Task<IActionResult> Contact(ContactViewModel contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var message = new EmailMessage();
                    message.HtmlBody = contact.Message;
                    message.Subject = contact.Subject;
                    message.ReplyDisplayName = contact.Name;
                    message.ReplyEmail = contact.Email;

                    var result = await EmailService.SendEmailMessageToAdminAsync(message);

                    if (result.IsSuccess)
                    {
                        //Clears all post data
                        //https://stackoverflow.com/questions/1775170/asp-net-mvc-modelstate-clear
                        ViewData.ModelState.Clear();

                        return View().WithSuccess(this, Messages.MessageSentSuccessfully);
                    }
                    else
                    {
                        HandleUpdateException(result, null, true);
                    }
                }
                catch (Exception ex)
                {
                    HandleUpdateException(ex);
                }
            }

            if (contact.Message == null)
            {
                ViewData.ModelState.Clear();
            }

            return View(contact);
        }

        [Route("sitemap.xml")]
        public async Task<ActionResult> SitemapXml()
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var sitemapNodes = await GetSitemapNodes(cts.Token);
            string xml = GetSitemapDocument(sitemapNodes);
            return this.Content(xml, "text/xml", Encoding.UTF8);
        }

        protected async override Task<IList<SitemapNode>> GetSitemapNodes(CancellationToken cancellationToken)
        {
            IList<SitemapNode> nodes = await base.GetSitemapNodes(cancellationToken);

            //Locations
            nodes.Add(
                 new SitemapNode()
                 {
                     Url = Url.AbsoluteUrl<LocationsController>(c => c.Index(1, 20, nameof(LocationDto.Name) + " asc", ""), AppSettings, false),
                     Priority = 0.9
                 });

            //countries
            nodes.Add(
             new SitemapNode()
             {
                 Url = Url.AbsoluteUrl<CountriesController>(c => c.Index(1, 20, nameof(LocationDto.Name) +" asc", ""), AppSettings, false),
                 Priority = 0.9
             });

            foreach (TagDto t in (await _blogService.TagApplicationService.GetAllAsync(cancellationToken, null, null, null)))
            {
                nodes.Add(
                   new SitemapNode()
                   {
                       Url = Url.AbsoluteUrl(nameof(BlogController.Tag), "Blog", AppSettings, new { tagSlug = t.UrlSlug }),
                       Frequency = SitemapFrequency.Weekly,
                       Priority = 0.8
                   });
            }

            foreach (CategoryDto c in (await _blogService.CategoryApplicationService.GetAsync(cancellationToken, c => c.Published, null, null)))
            {
                nodes.Add(
                   new SitemapNode()
                   {
                       Url = Url.AbsoluteUrl(nameof(BlogController.Category), "Blog", AppSettings, new { categorySlug = c.UrlSlug }),
                       Frequency = SitemapFrequency.Weekly,
                       Priority = 0.8
                   });
            }

            foreach (BlogPostDto p in (await _blogService.BlogPostApplicationService.GetPostsAsync(0, 200, cancellationToken)))
            {
                nodes.Add(
                   new SitemapNode()
                   {
                       Url = Url.AbsoluteUrl<BlogController>(c => c.Post(p.CreatedOn.Year, p.CreatedOn.Month, p.UrlSlug), AppSettings),
                       Frequency = SitemapFrequency.Weekly,
                       Priority = 0.7
                   });
            }

            var repository = _fileSystemGenericRepositoryFactory.CreateFolderRepository(cancellationToken, _hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Gallery]));
            foreach (DirectoryInfo f in (await repository.GetAllAsync(UIHelper.GetOrderByIQueryableDelegate<DirectoryInfo>(nameof(DirectoryInfo.LastWriteTime) + " desc"), null, null)))
            {
                nodes.Add(
                   new SitemapNode()
                   {
                       Url = Url.AbsoluteUrl("Gallery", "Gallery", AppSettings, new { name = f.Name.ToSlug() }),
                       Frequency = SitemapFrequency.Weekly,
                       Priority = 0.7
                   });
            }

            foreach (LocationDto l in (await _locationService.GetAllAsync(cancellationToken, null, null, null)))
            {
                if (!string.IsNullOrEmpty(l.UrlSlug))
                {
                    nodes.Add(
                       new SitemapNode()
                       {
                           Url = Url.AbsoluteUrl<LocationsController>(lc => lc.Location(l.UrlSlug), AppSettings),
                           Frequency = SitemapFrequency.Weekly,
                           Priority = 0.6
                       });
                }
            }

            return nodes;
        }

        protected override string SiteTitle
        {
            get
            {
                return AppSettings.SiteTitle;
            }
        }

        protected override string SiteDescription
        {
            get
            {
                return AppSettings.SiteDescription;
            }

        }

        protected override string SiteUrl
        {
            get
            {
                return AppSettings.SiteUrl;
            }

        }

        [Route("Error")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Spa")]
        public IActionResult Spa()
        {
            return View();
        }
    }
}

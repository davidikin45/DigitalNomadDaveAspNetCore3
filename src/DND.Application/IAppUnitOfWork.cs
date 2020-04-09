using AspNetCore.Mvc.Extensions.Data.UnitOfWork;
using DND.Domain.Blog.Authors;
using DND.Domain.Blog.BlogPosts;
using DND.Domain.Blog.Categories;
using DND.Domain.Blog.Locations;
using DND.Domain.Blog.Tags;
using DND.Domain.CMS.CarouselItems;
using DND.Domain.CMS.ContentHtmls;
using DND.Domain.CMS.ContentTexts;
using DND.Domain.CMS.Faqs;
using DND.Domain.CMS.MailingLists;
using DND.Domain.CMS.Projects;
using DND.Domain.CMS.Testimonials;

namespace DND.Application
{
    public interface IAppUnitOfWork : IUnitOfWork
    {
        IAuthorRepository AuthorRepository { get; }
        IBlogPostRepository BlogPostRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ILocationRepository LocationRepository { get; }
        ITagRepository TagRepository { get; }

        ICarouselItemRepository CarouselItemRepository { get; }
        IContentHtmlRepository ContentHtmlRepository { get; }
        IContentTextRepository ContentTextRepository { get; }
        IFaqRepository FaqRepository { get; }
        IMailingListRepository MailingListRepository { get; }
        IProjectRepository ProjectRepository { get; }
        ITestimonialRepository TestimonialRepository { get; }
    }
}

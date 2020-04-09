using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.Alerts;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using AspNetCore.Mvc.Extensions.Email;
using AspNetCore.Mvc.Extensions.Helpers;
using DND.Application;
using DND.Application.CMS.MailingLists.Dtos;
using DND.Application.CMS.MailingLists.Services;
using DND.Web.Areas.Admin.Controllers.MailingList.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DND.Web.Areas.Admin.Controllers.MailingList
{
    [Area("Admin")]
    [ResourceCollection(ResourceCollections.CMS.MailingList.CollectionId)]
    [Route("admin/cms/mailing-list")]
    public class MailingListController : MvcControllerEntityAuthorizeBase<MailingListDto, MailingListDto, MailingListDto, MailingListDeleteDto, IMailingListApplicationService>
    {
        public MailingListController(ControllerServicesContext context, IMailingListApplicationService service)
             : base(context, true, service)
        {
        }

        [Route("email")]
        public virtual ActionResult Email()
        {
            var instance = new MailingListEmailViewModel();
            ViewBag.PageTitle = "Mailing List Email";
            ViewBag.Admin = Admin;

            //return View("~/Views/Bootstrap4/Edit.cshtml", data);
            return View("Email", instance);
        }

        // POST: Default/Create
        [HttpPost]
        [Route("email")]
        public virtual async Task<ActionResult> Email(MailingListEmailViewModel email)
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            if (ModelState.IsValid)
            {
                try
                {
                    var data = await Service.GetAllAsync(cts.Token);

                    List<EmailMessage> list = new List<EmailMessage>();

                    foreach (MailingListDto dto in data)
                    {
                        var message = new EmailMessage();
                        message.HtmlBody = email.Body;
                        message.Subject = email.Subject;
                        message.ToEmail = dto.Email;
                        message.ToDisplayName = dto.Name;

                        list.Add(message);
                    }

                    EmailService.SendEmailMessages(list);

                    return RedirectToAction<MailingListController>(c => c.Email()).WithSuccess(this, Messages.AddSuccessful);
                }
                catch (Exception ex)
                {
                    HandleUpdateException(ex);
                }
            }
            //error

            //return View("~/Views/Bootstrap4/Edit.cshtml", data);
            return View("Email", email);
        }
    }
}

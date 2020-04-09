using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using AutoMapper;
using DND.Application;
using DND.Application.Blog.Tags.Dtos;
using DND.Application.Blog.Tags.Services;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.Tags
{
    [Area("Admin")]
    [ResourceCollection(ResourceCollections.Blog.Tags.CollectionId)]
    [Route("admin/blog/tags")]
    public class TagsController : MvcControllerEntityAuthorizeBase<TagDto, TagDto, TagDto, TagDeleteDto, ITagApplicationService>
    {
        public TagsController(ControllerServicesContext context, ITagApplicationService service)
             : base(context, true, service)
        {
        }
    }
}

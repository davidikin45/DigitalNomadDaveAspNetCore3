using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using AutoMapper;
using DND.Application;
using DND.Application.Blog.Tags.Dtos;
using DND.Application.Blog.Tags.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.Blog
{
    [Authorize(Roles = "admin")]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/blog/tags")]
    public class TagsController : ApiControllerEntityAuthorizeBase<TagDto, TagDto, TagDto, TagDeleteDto, ITagApplicationService>
    {
        public TagsController(ControllerServicesContext context, ITagApplicationService service, IMapper mapper)
            : base(context, service)
        {

        }

    }
}

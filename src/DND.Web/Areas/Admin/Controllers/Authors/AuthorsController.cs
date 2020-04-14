using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using DND.Application;
using DND.Application.Blog.Authors.Dtos;
using DND.Application.Blog.Authors.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.Authors
{
    [Authorize(Roles ="admin")]
    [Area("Admin")]
    [ResourceCollection(ResourceCollections.Blog.Authors.CollectionId)]
    [Route("admin/blog/authors")]
    public class AuthorsController : MvcControllerEntityAuthorizeBase<AuthorDto, AuthorDto, AuthorDto, AuthorDeleteDto, IAuthorApplicationService>
    {
        public AuthorsController(ControllerServicesContext context, IAuthorApplicationService service)
             : base(context, true, service)
        {
        }
    }
}

using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using DND.Application;
using DND.Application.Blog.Authors.Dtos;
using DND.Application.Blog.Authors.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.Blog
{
    [ResourceCollection(ResourceCollections.Blog.Authors.CollectionId)]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/blog/authors")]
    public class AuthorsController : ApiControllerEntityAuthorizeBase<AuthorDto, AuthorDto, AuthorDto, AuthorDeleteDto, IAuthorApplicationService>
    {
        public AuthorsController(ControllerServicesContext context, IAuthorApplicationService service)
            : base(context, service)
        {

        }
    }
}

using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using AspNetCore.Mvc.Extensions.Cqrs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/cqrs")]
    public class CqrsController : ApiControllerCqrsAuthorizeBase
    {
        public CqrsController(ControllerServicesContext context, ICqrsMediator cqrsMediator)
            : base(context, cqrsMediator)
        {

        }
    }
}

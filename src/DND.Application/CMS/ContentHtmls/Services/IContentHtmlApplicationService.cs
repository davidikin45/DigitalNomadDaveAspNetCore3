using AspNetCore.Mvc.Extensions.Application;
using DND.Application.CMS.ContentHtmls.Dtos;

namespace DND.Application.CMS.ContentHtmls.Services
{
    public interface IContentHtmlApplicationService : IApplicationServiceEntity<ContentHtmlDto, ContentHtmlDto, ContentHtmlDto, ContentHtmlDeleteDto>
    {
    }
}

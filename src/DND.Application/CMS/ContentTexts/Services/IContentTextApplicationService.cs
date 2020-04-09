using AspNetCore.Mvc.Extensions.Application;
using DND.Application.CMS.ContentTexts.Dtos;

namespace DND.Application.CMS.ContentTexts.Services
{
    public interface IContentTextApplicationService : IApplicationServiceEntity<ContentTextDto, ContentTextDto, ContentTextDto, ContentTextDeleteDto>
    {
    }
}

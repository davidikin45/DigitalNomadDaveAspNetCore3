using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.CMS.ContentHtmls;

namespace DND.Application.CMS.ContentHtmls.Dtos
{
    public class ContentHtmlDeleteDto : DtoAggregateRootBase<string>, IMapTo<ContentHtml>, IMapFrom<ContentHtml>
    {


    }
}

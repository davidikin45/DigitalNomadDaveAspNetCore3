using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.CMS.ContentTexts;

namespace DND.Application.CMS.ContentTexts.Dtos
{
    public class ContentTextDeleteDto : DtoAggregateRootBase<string>, IMapTo<ContentText>, IMapFrom<ContentText>
    {

    }
}

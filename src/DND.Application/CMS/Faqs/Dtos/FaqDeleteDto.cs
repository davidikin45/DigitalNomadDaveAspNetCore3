using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.CMS.Faqs;

namespace DND.Application.CMS.Faqs.Dtos
{
    public class FaqDeleteDto : DtoAggregateRootBase<int>, IMapTo<Faq>, IMapFrom<Faq>
    {

    }
}

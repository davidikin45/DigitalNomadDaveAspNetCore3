using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.CMS.MailingLists;

namespace DND.Application.CMS.MailingLists.Dtos
{
    public class MailingListDeleteDto : DtoAggregateRootBase<int>, IMapTo<MailingList>, IMapFrom<MailingList>
    {

    }
}

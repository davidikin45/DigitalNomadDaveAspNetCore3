using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.MailingLists;

namespace DND.Domain.CMS.MailingLists
{
    public interface IMailingListRepository : IGenericRepository<MailingList>
    {
    }
}

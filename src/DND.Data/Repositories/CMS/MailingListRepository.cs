using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.MailingLists;

namespace DND.Data.Repositories.CMS
{
    public class MailingListRepository : GenericRepository<MailingList>, IMailingListRepository
    {
        public MailingListRepository(AppContext context)
            : base(context)
        {

        }
    }
}

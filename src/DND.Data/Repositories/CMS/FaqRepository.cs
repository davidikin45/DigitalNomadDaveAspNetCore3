using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.Faqs;

namespace DND.Data.Repositories.CMS
{
    public class FaqRepository : GenericRepository<Faq>, IFaqRepository
    {
        public FaqRepository(AppContext context)
            : base(context)
        {

        }
    }
}

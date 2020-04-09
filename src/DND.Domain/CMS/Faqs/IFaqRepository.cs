using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.Faqs;

namespace DND.Domain.CMS.Faqs
{
    public interface IFaqRepository : IGenericRepository<Faq>
    {
    }
}

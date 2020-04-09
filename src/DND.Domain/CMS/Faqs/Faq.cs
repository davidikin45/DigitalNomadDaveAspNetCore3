using AspNetCore.Mvc.Extensions.Domain;

namespace DND.Domain.CMS.Faqs
{
    public class Faq : EntityAggregateRootBase<int>
    {
        //[Required]
        public string Question { get; set; }

        //[Required]
        public string Answer { get; set; }

    }
}

using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.ContentHtmls;

namespace DND.Data.Repositories.CMS
{
    public class ContentHtmlRepository : GenericRepository<ContentHtml>, IContentHtmlRepository
    {
        public ContentHtmlRepository(AppContext context)
            : base(context)
        {

        }

        public override void Delete(ContentHtml entity, string deletedBy)
        {
            entity.Deleted = true;
            base.Delete(entity, deletedBy);
        }
    }
}

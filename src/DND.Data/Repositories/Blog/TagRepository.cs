using AspNetCore.Mvc.Extensions.Data.Repository;
using AspNetCore.Mvc.Extensions.Helpers;
using DND.Domain.Blog.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Data.Repositories.Blog
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(AppContext context)
            :base(context)
        {

        }

        public Task<Tag> GetTagAsync(string tagSlug, CancellationToken cancellationToken)
        {
            return GetFirstAsync(cancellationToken, t => t.UrlSlug.Equals(tagSlug));
        }

        public override Task<IReadOnlyList<Tag>> GetAsync(CancellationToken cancellationToken, Expression<Func<Tag, bool>> filter = null, Func<IQueryable<Tag>, IOrderedQueryable<Tag>> orderBy = null, int? skip = null, int? take = null, bool getFullGraph = false, params Expression<Func<Tag, object>>[] includeProperties)
        {
            return GetAllAsync(cancellationToken, o => o.OrderBy(c => c.Name));
        }

        public override Tag Add(Tag entity, string addedBy)
        {
            if (string.IsNullOrEmpty(entity.UrlSlug))
            {
                entity.UrlSlug = UrlSlugger.ToUrlSlug(entity.Name);
            }
            return base.Add(entity, addedBy);
        }

        public override Tag Update(Tag entity, string updatedBy)
        {
            if (string.IsNullOrEmpty(entity.UrlSlug))
            {
                entity.UrlSlug = UrlSlugger.ToUrlSlug(entity.Name);
            }

            return base.Update(entity, updatedBy);
        }
    }
}

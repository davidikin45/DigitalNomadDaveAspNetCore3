using AspNetCore.Mvc.Extensions.Data.Repository;
using AspNetCore.Mvc.Extensions.Helpers;
using DND.Domain.Blog.BlogPosts;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Data.Repositories.Blog
{
    public class BlogPostRepository : GenericRepository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(AppContext context)
            :base(context)
        {

        }

        public Task<BlogPost> GetPostAsync(int year, int month, string titleSlug, CancellationToken cancellationToken)
        {
            return GetFirstAsync(cancellationToken, p => p.CreatedOn.Year == year && p.CreatedOn.Month == month && p.UrlSlug.Equals(titleSlug), null, true);
        }

        public IReadOnlyList<BlogPost> GetPosts(int pageNo, int pageSize)
        {
            return Get(p => p.Published, o => o.OrderByDescending(p => p.CreatedOn), pageNo * pageSize, pageSize, true);
        }

        public Task<IReadOnlyList<BlogPost>> GetPostsAsync(int pageNo, int pageSize, CancellationToken cancellationToken)
        {
            return GetAsync(cancellationToken, p => p.Published, o => o.OrderByDescending(p => p.CreatedOn), pageNo * pageSize, pageSize, true);
        }

        public Task<IReadOnlyList<BlogPost>> GetPostsAsyncWithLocation(int pageNo, int pageSize, CancellationToken cancellationToken)
        {
           return GetAsync(cancellationToken, p => p.Published, o => o.OrderByDescending(p => p.CreatedOn), pageNo * pageSize, pageSize, true);
        }

        public async Task<IEnumerable<BlogPost>> GetPostsForAuthorAsync(string authorSlug, int pageNo, int pageSize, CancellationToken cancellationToken)
        {
            return await GetAsync(cancellationToken, p => p.Published && p.Author.UrlSlug.Equals(authorSlug), o => o.OrderByDescending(p => p.CreatedOn), pageNo * pageSize, pageSize, true).ConfigureAwait(false);
        }

        public async Task<IEnumerable<BlogPost>> GetPostsForCarouselAsync(int pageNo, int pageSize, CancellationToken cancellationToken)
        {
            return await GetAsync(cancellationToken, p => p.Published && p.ShowInCarousel, o => o.OrderByDescending(p => p.CreatedOn), pageNo * pageSize, pageSize);
        }

        public async Task<IEnumerable<BlogPost>> GetPostsForCategoryAsync(string categorySlug, int pageNo, int pageSize, CancellationToken cancellationToken)
        {
           return await GetAsync(cancellationToken, p => p.Published && p.Category.UrlSlug.Equals(categorySlug), o => o.OrderByDescending(p => p.CreatedOn), pageNo * pageSize, pageSize, true).ConfigureAwait(false);
        }

        public async Task<IEnumerable<BlogPost>> GetPostsForSearchAsync(string search, int pageNo, int pageSize, CancellationToken cancellationToken)
        {
           return await GetAsync(cancellationToken, p => p.Published && (p.Title.Contains(search) || p.Category.Name.Equals(search) || p.Author.Name.Equals(search) || p.Tags.Any(t => t.Tag.Name.Equals(search)) || p.Locations.Any(l => l.Location.Name.Equals(search))), o => o.OrderByDescending(p => p.CreatedOn), pageNo * pageSize, pageSize,  true).ConfigureAwait(false);
        }

        public async Task<IEnumerable<BlogPost>> GetPostsForTagAsync(string tagSlug, int pageNo, int pageSize, CancellationToken cancellationToken)
        {
           return await GetAsync(cancellationToken, p => p.Published && p.Tags.Any(t => t.Tag.UrlSlug.Equals(tagSlug)), o => o.OrderByDescending(p => p.CreatedOn), pageNo * pageSize, pageSize, true).ConfigureAwait(false);
        }

        public Task<int> GetTotalPostsAsync(bool checkIsPublished, CancellationToken cancellationToken)
        {
            return GetCountAsync(cancellationToken, p => !checkIsPublished || p.Published);
        }

        public Task<int> GetTotalPostsForAuthorAsync(string authorSlug, CancellationToken cancellationToken)
        {
            return GetCountAsync(cancellationToken, p => p.Published && p.Author.UrlSlug.Equals(authorSlug));
        }

        public Task<int> GetTotalPostsForCategoryAsync(string categorySlug, CancellationToken cancellationToken)
        {
            return GetCountAsync(cancellationToken, p => p.Published && p.Category.UrlSlug.Equals(categorySlug));
        }

        public Task<int> GetTotalPostsForSearchAsync(string search, CancellationToken cancellationToken)
        {
          return GetCountAsync(cancellationToken, p => p.Published && (p.Title.Contains(search) || p.Category.Name.Equals(search) || p.Author.Name.Equals(search) || p.Tags.Any(t => t.Tag.Name.Equals(search))) || p.Locations.Any(l => l.Location.Name.Equals(search)));
        }

        public Task<int> GetTotalPostsForTagAsync(string tagSlug, CancellationToken cancellationToken)
        {
           return GetCountAsync(cancellationToken, p => p.Published && p.Tags.Any(t => t.Tag.UrlSlug.Equals(tagSlug)));
        }

        public override BlogPost Add(BlogPost entity, string addedBy)
        {
            if (string.IsNullOrEmpty(entity.UrlSlug))
            {
                entity.UrlSlug = UrlSlugger.ToUrlSlug(entity.Title);
            }

            return base.Add(entity, addedBy);
        }

        public override BlogPost Update(BlogPost entity, string updatedBy)
        {
            if (string.IsNullOrEmpty(entity.UrlSlug))
            {
                entity.UrlSlug = UrlSlugger.ToUrlSlug(entity.Title);
            }

            return base.Update(entity, updatedBy);
        }
    }
}

using AspNetCore.Mvc.Extensions.Domain;
using DND.Domain.Blog.Locations;

namespace DND.Domain.Blog.BlogPosts
{
    public class BlogPostLocation : EntityChildBase<int>
    {
        //[Required]
        public int BlogPostId { get; set; }
        //public virtual BlogPost BlogPost { get; set; }

        //[Required]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        public BlogPostLocation()
        {

        }
    }
}

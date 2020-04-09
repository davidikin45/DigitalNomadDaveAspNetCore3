using AspNetCore.Mvc.Extensions.Domain;
using DND.Domain.Blog.Tags;

namespace DND.Domain.Blog.BlogPosts
{
    public class BlogPostTag : EntityChildBase<int>
    {
        //[Required]
        public int BlogPostId { get; set; }
        //public virtual BlogPost BlogPost { get; set; }

        //[Required]
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }

        public BlogPostTag()
        {

        }
    }
}

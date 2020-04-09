using DND.Application.Blog.BlogPosts.Dtos;
using DND.Application.Blog.Categories.Dtos;
using DND.Application.Blog.Tags.Dtos;
using System.Collections.Generic;
using System.IO;

namespace DND.Web.Controllers.Sidebar.Models
{
    public class BlogWidgetViewModel
    {
        public IList<CategoryDto> Categories { get; set; }
        public IList<TagDto> Tags { get; set; }
        public IList<BlogPostDto> LatestPosts { get; set; }
        public IList<FileInfo> LatestPhotos { get; set; }
    }
}

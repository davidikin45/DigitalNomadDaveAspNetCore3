using DND.Application.Blog.BlogPosts.Dtos;
using DND.Application.CMS.CarouselItems.Dtos;
using System.Collections.Generic;
using System.IO;

namespace DND.Web.Areas.Frontend.Controllers.CarouselItem.Models
{
    public class CarouselViewModel
    {
        public int ItemCount { get; set; }
        public IList<BlogPostDto> Posts { get; set; }

        public IList<DirectoryInfo> Albums { get; set; }
        public IList<CarouselItemDto> AlbumCarouselItems { get; set; }

        public IList<CarouselItemDto> CarouselItems { get; set; }
    }
}

using AspNetCore.Mvc.Extensions.Attributes.Display;
using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using DND.Application.Blog.Tags.Dtos;
using DND.Domain.Blog.Tags;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace DND.Domain.Blog.BlogPosts.Dtos
{
    public class BlogPostTagDto : DtoBase<int>, IHaveCustomMappings
    {
        [HiddenInput()]
        [ReadOnlyHiddenInput(ShowForCreate = false, ShowForEdit = false), Display(Order = 0)]
        public override int Id { get => base.Id; set => base.Id = value; }

        [Required]
        [DropdownDbContext("DND.Data.AppContext, DND.Data", typeof(Tag), nameof(DND.Domain.Blog.Tags.Tag.Name))]
        public int TagId { get; set; }

        [HiddenInput()]
        public int BlogPostId { get; set; }

        [Render(ShowForGrid = false, ShowForDisplay = false, ShowForEdit = false, ShowForCreate = false)]
        public TagDto Tag { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<BlogPostTag, BlogPostTagDto>().ReverseMap().EqualityComparison((d, e) => d.Id == e.Id);
        }
    }
}

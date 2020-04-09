using AspNetCore.Mvc.Extensions.Attributes.Display;
using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using AutoMapper;
using DND.Application.Blog.Locations.Dtos;
using DND.Domain.Blog.BlogPosts;
using DND.Domain.Blog.Locations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper.EquivalencyExpression;

namespace DND.Application.Blog.BlogPosts.Dtos
{
    public class BlogPostLocationDto : DtoBase<int>, IHaveCustomMappings
    {
        [HiddenInput()]
        [ReadOnlyHiddenInput(ShowForCreate = false, ShowForEdit = false), Display(Order = 0)]
        public override int Id { get => base.Id; set => base.Id = value; }

        [Required]
        [DropdownDbContext("DND.Data.AppContext, DND.Data", typeof(Location), "{" + nameof(DND.Domain.Blog.Locations.Location.LocationTypeDescription) + "} - {" + nameof(DND.Domain.Blog.Locations.Location.Name) + "}")]
        public int LocationId { get; set; }

        [HiddenInput()]
        public int BlogPostId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [Render(ShowForGrid = false, ShowForDisplay = false, ShowForEdit = false, ShowForCreate = false)]
        public LocationDto Location { get; set; }


        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<BlogPostLocation, BlogPostLocationDto>().ReverseMap().EqualityComparison((d, e) => d.Id == e.Id);
        }
    }
}

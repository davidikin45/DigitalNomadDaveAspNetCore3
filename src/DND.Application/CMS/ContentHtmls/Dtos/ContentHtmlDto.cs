﻿using AspNetCore.Mvc.Extensions.Attributes.Display;
using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using AutoMapper;
using DND.Domain.CMS.ContentHtmls;
using Microsoft.AspNetCore.Mvc;

namespace DND.Application.CMS.ContentHtmls.Dtos
{
    public class ContentHtmlDto : DtoAggregateRootBase<string>, IHaveCustomMappings
    {
        [ReadOnlyHiddenInput(ShowForCreate = false, ShowForEdit = true)]
        public override string Id { get => base.Id; set => base.Id = value; }

        [MultilineText(HTML = true, Rows = 7)]
        public string HTML { get; set; }

        [HiddenInput]
        public bool PreventDelete { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<ContentHtmlDto, ContentHtml>()
             .ForMember(bo => bo.UpdatedOn, dto => dto.Ignore())
            .ForMember(bo => bo.CreatedOn, dto => dto.Ignore());

            configuration.CreateMap<ContentHtml, ContentHtmlDto>();
        }
    }
}

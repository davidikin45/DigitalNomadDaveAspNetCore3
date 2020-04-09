using AspNetCore.Mvc.Extensions.Attributes.Display;
using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using AutoMapper;
using DND.Domain.CMS.MailingLists;
using System;
using System.ComponentModel.DataAnnotations;

namespace DND.Application.CMS.MailingLists.Dtos
{
    public class MailingListDto : DtoAggregateRootBase<int>, IHaveCustomMappings
    {
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Render(ShowForEdit = false, ShowForGrid = true)]
        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<MailingList, MailingListDto>();

            configuration.CreateMap<MailingListDto, MailingList>()
           .ForMember(bo => bo.CreatedOn, dto => dto.Ignore())
           .ForMember(bo => bo.UpdatedOn, dto => dto.Ignore());
        }

    }
}

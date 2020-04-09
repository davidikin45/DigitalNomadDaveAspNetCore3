using AspNetCore.Mvc.Extensions.Application;
using DND.Application.CMS.MailingLists.Dtos;

namespace DND.Application.CMS.MailingLists.Services
{
    public interface IMailingListApplicationService : IApplicationServiceEntity<MailingListDto, MailingListDto, MailingListDto, MailingListDeleteDto>
    {
    }
}

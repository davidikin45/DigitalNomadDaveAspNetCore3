using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.File;
using AspNetCore.Mvc.Extensions.Data.RepositoryFileSystem;
using AspNetCore.Mvc.Extensions.Email;
using AspNetCore.Mvc.Extensions.Settings;
using AutoMapper;
using DND.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.Home
{
    [Authorize(Roles = "admin")]
    [Area("Admin")]
    [Route("admin/file-metadata")]
    public class FileMetadataController : MvcControllerFileMetadataAuthorizeBase
    {
        public FileMetadataController(ControllerServicesContext context, IFileSystemGenericRepositoryFactory fileSytemGenericRepositoryFactory, IMapper mapper, IEmailService emailService, AppSettings appSettings, IWebHostEnvironment hostingEnvironment)
             : base(context, hostingEnvironment.MapWwwPath(appSettings.Folders[Folders.Files]), true, true, fileSytemGenericRepositoryFactory, mapper, emailService)
        {

        }
    }
}

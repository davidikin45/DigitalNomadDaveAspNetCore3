﻿using AspNetCore.Mvc.Extensions.Data.RepositoryFileSystem;
using AspNetCore.Mvc.Extensions.Helpers;
using AspNetCore.Mvc.Extensions.ViewComponents;
using DND.Application.CMS.Projects.Dtos;
using DND.Application.CMS.Projects.Services;
using DND.Web.Areas.Frontend.Controllers.Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.Project.ViewComponents
{
    public class ProjectViewComponent : ViewComponentBase
    {
        private readonly IProjectApplicationService _projectService;
        private readonly IFileSystemGenericRepositoryFactory _fileSystemRepository;

        public ProjectViewComponent(IProjectApplicationService projectService, IFileSystemGenericRepositoryFactory fileSystemRepository)
        {
            _fileSystemRepository = fileSystemRepository;
            _projectService = projectService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string orderColumn = nameof(ProjectDto.CreatedOn) + " desc";

            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            IEnumerable<ProjectDto> projects = null;


            var projectsTask = _projectService.GetAllAsync(cts.Token, orderColumn, null, null);

            await TaskHelper.WhenAllOrException(cts, projectsTask);

            projects = projectsTask.Result;


            var viewModel = new ProjectsViewModel
            {
                Projects = projects.ToList()
            };

            return View(viewModel);
        }

    }
}

﻿using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.Shared;

namespace Savitar.Server.Controllers
{
    public class ProjectsController : BaseApiEntityController<Project, IProjectsRepository>
    {
        public ProjectsController(IProjectsRepository repository) : base(repository) { }
    }
}

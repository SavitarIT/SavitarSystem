﻿using Savitar.Domain.Models.Entities;
using Savitar.Infrastructure.Repository.Shared;

namespace Savitar.Infrastructure.Repository.EFCore
{
    internal class ServicesRepository : Repository<Service, ApplicationDbContext>, IServicesRepository
    {
        public ServicesRepository(ApplicationDbContext context) : base(context) { }
    }
}
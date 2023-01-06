﻿using Caravan.DataAccess.DbContexts;
using Caravan.DataAccess.Interfaces;
using Caravan.DataAccess.Repositories.Comman;
using Caravan.Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan.DataAccess.Repositories
{
    public class LocationRepository : GenericRepository<Location>, 
        ILocationRepository
    {
        public LocationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}

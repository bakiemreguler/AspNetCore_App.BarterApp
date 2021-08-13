using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Repository;
using BarterAppSolution.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Data.Repository
{
    class LocationDataRepository : Repository<LocationData>, ILocationDataRepository
    {
        private DatabaseContext _context { get => _dbContext as DatabaseContext; }
        public LocationDataRepository(DatabaseContext context) : base(context) { }
    }
}

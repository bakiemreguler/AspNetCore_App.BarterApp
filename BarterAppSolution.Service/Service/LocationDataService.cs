using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Service;
using BarterAppSolution.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Service.Service
{
    public class LocationDataService : Service<LocationData>, ILocationDataService
    {
        public LocationDataService(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}

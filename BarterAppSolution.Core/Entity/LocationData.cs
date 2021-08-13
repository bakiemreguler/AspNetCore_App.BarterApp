using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Core.Entity
{
    public class LocationData : AuditableEntity
    {
        public string ServiceTitle { get; set; }
        public string DeviceTitle { get; set; }
        public string DeviceMac { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string AddressInfo { get; set; }
        public string Explanation { get; set; }
        public string AppState { get; set; }
    }
}

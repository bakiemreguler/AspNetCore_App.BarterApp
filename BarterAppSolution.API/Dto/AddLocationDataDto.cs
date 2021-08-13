using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Dto
{
    public class AddLocationDataDto
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string address { get; set; }
        public string explanation { get; set; }
        public string service_title { get; set; }
        public string device_title { get; set; }
        public string device_mac { get; set; }
        public string app_state { get; set; }
    }
}

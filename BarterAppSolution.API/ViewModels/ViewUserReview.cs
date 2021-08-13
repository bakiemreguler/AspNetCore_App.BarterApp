using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarterAppSolution.API.ViewModels
{
    public class ViewUserReview
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_surname { get; set; }
        public string notes { get; set; }
        public int user_score { get; set; }
    }
}

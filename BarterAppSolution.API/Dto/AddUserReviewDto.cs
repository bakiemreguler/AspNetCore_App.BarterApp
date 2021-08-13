using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Dto
{
    public class AddUserReviewDto
    {
        public int user_id { get; set; }
        public int user_score { get; set; }
        public string notes { get; set; }
    }
}

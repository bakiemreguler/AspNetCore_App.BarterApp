using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Dto
{
    public class ViewUserDto
    {
        public int user_id { get; set; }
        public string user_role { get; set; }
        public string user_name { get; set; }
        public string user_surname { get; set; }
        public string user_profile_photo { get; set; }
        public bool user_is_verified { get; set; }
        public bool user_is_female { get; set; }
        public string user_mail_address { get; set; }
    }
}

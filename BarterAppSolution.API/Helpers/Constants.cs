using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Helpers
{
    public static class Constants
    {
        public static int portNum = 587;
        public static string hostName = "smtp.live.com";
        public static string mailUserName = "bakiemreguler@hotmail.com";
        public static string mailUserPass = "Bkmrglr.94";
        public static string senderName = "Barter App";
        public static string baseUrl = "https://localhost:44376/api/";

        public const string RoleAdministrator = "Administrator";
        public const string RoleDefaultUser = "Standart Kullanıcı";
    }
}

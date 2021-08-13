using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;

namespace BarterAppSolution.Service.Helpers
{
    public static class Utils
    {
        public static int GetUserIdFromToken(HttpRequest Request)
        {
            if (Request == null)
                return 1;

            var accessToken = Request.Headers["Authorization"].ToString().Replace("Bearer ", String.Empty);
            var token = new JwtSecurityTokenHandler().ReadJwtToken(accessToken);
            var kullaniciId = token.Claims.First(claim => claim.Type == "Id").Value;

            return Convert.ToInt32(kullaniciId);
        }
    }
}

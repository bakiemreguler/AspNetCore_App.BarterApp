using BarterAppSolution.API.Models;
using BarterAppSolution.Core.Entity;
using FluentValidation.Results;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Helpers
{
    public class Utils
    {
        public static ServiceResult<object> GenerateServiceResult(HttpStatusCode httpStatusCode, bool isSuccess, object data = null, string explanation = "")
        {
            return new ServiceResult<object>()
            {
                dataToReturn = data,
                explanation = isSuccess ? explanation : (String.IsNullOrWhiteSpace(explanation) ? "Bir Hata Oluştu" : explanation),
                isSuccess = isSuccess,
                statusCode = httpStatusCode
            };
        }
        public static ServiceResult<object> ValidationErrorResult(ValidationResult validationResult)
        {
            List<string> errorMessages = validationResult.Errors.Select(a => a.ErrorMessage).ToList();
            string explanation = String.Join(" ", errorMessages.ToArray());

            return new ServiceResult<object>()
            {
                dataToReturn = null,
                explanation = explanation,
                isSuccess = false,
                statusCode = HttpStatusCode.BadRequest
            };
        }
        public static ServiceResult<object> ModelIsNotValidResult(List<string> errorMessages)
        {
            string explanation = String.Join(" ", errorMessages.ToArray());

            return new ServiceResult<object>()
            {
                dataToReturn = null,
                explanation = explanation,
                isSuccess = false,
                statusCode = HttpStatusCode.BadRequest
            };
        }

        public static string GenerateToken(User user, IConfiguration configuration)
        {
            var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, user.LoginName),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim("Id", user.Id.ToString()),
                        new Claim("Name", user.Name + " " + user.Surname.ToUpper()),
                        new Claim(ClaimTypes.Role, user.UserRole.Role),
                        new Claim("IsVerified", user.IsVerified.ToString())
                    };

            var token = new JwtSecurityToken
            (
                issuer: "*",
                audience: "*",
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Token:SecretKey"])), SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static bool SendEMail(string receiverMailAddress, string subject, string body)
        {
            try
            {
                var fromAddress = new MailAddress(Constants.mailUserName, Constants.senderName);
                var toAddress = new MailAddress(receiverMailAddress, receiverMailAddress);

                var smtp = new SmtpClient
                {
                    Host = Constants.hostName,
                    Port = Constants.portNum,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, Constants.mailUserPass)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                })
                {
                    smtp.Send(message);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

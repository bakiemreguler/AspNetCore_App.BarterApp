using AutoMapper;
using BarterAppSolution.API.Dto;
using BarterAppSolution.API.Helpers;
using BarterAppSolution.API.Models;
using BarterAppSolution.API.Validator;
using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using BarterAppSolution.API.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using BarterAppSolution.API.Filters;

namespace BarterAppSolution.API.Controllers
{
    //[ServiceFilter(typeof(LogFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IUserReviewService userReviewService;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly ILogger<UserController> logger;
        public UserController(IUserService userService, IUserReviewService userReviewService, IMapper mapper, IConfiguration configuration, ILogger<UserController> logger)
        {
            this.userService = userService;
            this.userReviewService = userReviewService;
            this.mapper = mapper;
            this.configuration = configuration;
            this.logger = logger;
        }

        [HttpGet("GetUserById")]
        [Authorize(Roles = Constants.RoleAdministrator)]
        public IActionResult GetUser(int id)
        {
            User user = userService.GetUserByIdWithRoles(id);

            if (user == null)
            {
                HttpStatusCode status = HttpStatusCode.OK;
                return StatusCode((int)status, Utils.GenerateServiceResult(status, false, null, "Kullanıcı Bulunamadı!"));
            }
            else
            {
                ViewUserDto userMapped = mapper.Map<User, ViewUserDto>(user);
                HttpStatusCode status = HttpStatusCode.OK;
                return StatusCode((int)status, Utils.GenerateServiceResult(status, true, userMapped));
            }
        }

        [HttpGet("GetUsers")]
        [Authorize(Roles = Constants.RoleAdministrator)]
        public IActionResult GetAllUsers()
        {
            List<User> users = userService.GetAll().Include(a => a.UserRole).ToList();
            List<ViewUserDto> usersMapped = mapper.Map<List<User>, List<ViewUserDto>>(users);

            HttpStatusCode status = HttpStatusCode.OK;
            return StatusCode((int)status, Utils.GenerateServiceResult(status, true, usersMapped));
        }

        [HttpPost("Register")]
        public IActionResult InsertNewUser([FromBody] AddUserDto addUserDto)
        {
            var validationResult = new SaveUserValidator(userService).Validate(addUserDto);

            if (!validationResult.IsValid)
                return StatusCode((int)HttpStatusCode.BadRequest, Utils.ValidationErrorResult(validationResult));

            User userToSave = mapper.Map<AddUserDto, User>(addUserDto);

            userToSave.UserRoleId = 2;
            userToSave.IsVerified = false;
            userToSave.ActivationLink = Guid.NewGuid().ToString("N");

            User userSaved = userService.Add(userToSave);
            ViewUserDto userMapped = mapper.Map<User, ViewUserDto>(userSaved);

            if(userSaved.Id > 0)
            {
                string subject = "Üyelik Aktivasyonu";
                string linkUrl = Constants.baseUrl + "User/ActivateUser?linkUrl=" + userSaved.Id + "-" + userSaved.ActivationLink;
                string body = "<h2>TAKASLA - Üyelik Aktivasyonu</h2><p>Sayın </p>" + userSaved.Name + " " + userSaved.Surname + ";<br /><br />Aşağıdaki linke tıklayarak üyelik aktivasyonunuzu tamamlayabilirsiniz.<br /><br /><a target='_blank' href='"+linkUrl+ "'>Üyeliğimi Aktif Et</a><br /><br />";
                Utils.SendEMail(userSaved.MailAddress, subject, body);
            }

            HttpStatusCode status = HttpStatusCode.Created;
            return StatusCode((int)status, Utils.GenerateServiceResult(status, true, userMapped));
        }

        [HttpPost("VerifyUser")]
        public IActionResult UserActivation(string linkUrl)
        {
            string activationLink = linkUrl.Split('-')[1];

            User user = userService.GetByActivationLink(activationLink);
            HttpStatusCode status = HttpStatusCode.OK;

            if (user != null)
            {
                user.IsVerified = true;
                userService.Update(user);
                ViewUserDto userMapped = mapper.Map<User, ViewUserDto>(user);
                return StatusCode((int)status, Utils.GenerateServiceResult(status, true, userMapped));
            }
            else
            {
                return StatusCode((int)status, Utils.GenerateServiceResult(status, false, null, "Kullanıcı Bulunamadı!"));
            }
        }

        [HttpPost("Login")]
        public IActionResult GetToken([FromBody] LoginDto loginDto)
        {
            var validationResult = new LoginUserValidator().Validate(loginDto);

            if (!validationResult.IsValid)
                return StatusCode((int)HttpStatusCode.BadRequest, Utils.ValidationErrorResult(validationResult));

            User user = userService.GetByUserNameAndPassword(loginDto.user_login_name, loginDto.user_password);

            if (user == null)
            {
                HttpStatusCode status = HttpStatusCode.Unauthorized;
                return StatusCode((int)status, Utils.GenerateServiceResult(status, false, null, "Kullanıcı Adı veya Şifre Hatalı!"));
            }
            else
            {
                user = userService.GetUserByIdWithRoles(user.Id);
                HttpStatusCode status = HttpStatusCode.OK;
                return StatusCode((int)status, Utils.GenerateServiceResult(status, true, Utils.GenerateToken(user, configuration)));
            }
        }

        #region User Reviews

        [HttpPost("AddReview")]
        [Authorize(Roles = Constants.RoleAdministrator)]
        public IActionResult InsertNewReview([FromBody] AddUserReviewDto addUserReviewDto)
        {
            var validationResult = new AddReviewValidator(userService).Validate(addUserReviewDto);

            if (!validationResult.IsValid)
                return StatusCode((int)HttpStatusCode.BadRequest, Utils.ValidationErrorResult(validationResult));

            UserReview userReview = mapper.Map<AddUserReviewDto, UserReview>(addUserReviewDto);

            userReview = userReviewService.Add(userReview, Request);

            if (userReview != null && userReview.Id > 0)
            {
                HttpStatusCode status = HttpStatusCode.Created;
                return StatusCode((int)status, Utils.GenerateServiceResult(status, true, userReview.Id));
            }
            else
            {
                HttpStatusCode status = HttpStatusCode.BadRequest;
                return StatusCode((int)status, Utils.GenerateServiceResult(status, false));
            }
        }

        [HttpGet("GetReviews")]
        [Authorize(Roles = Constants.RoleAdministrator)]
        public IActionResult GetUserReviews(int userId)
        {
            List<UserReview> userReviews = userReviewService.GetUserReviewsWithUser(userId).ToList();

            List<ViewUserReview> userReviewsMapped = mapper.Map<List<UserReview>, List<ViewUserReview>>(userReviews);
            HttpStatusCode status = HttpStatusCode.OK;
            return StatusCode((int)status, Utils.GenerateServiceResult(status, true, userReviewsMapped));
        }

        #endregion
    }
}

using BarterAppSolution.API.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Validator
{
    public class LoginUserValidator : AbstractValidator<LoginDto>
    {
        public LoginUserValidator()
        {
            RuleFor(a => a.user_login_name)
                .NotEmpty().WithMessage("Kullanıcı Adı Zorunludur.");

            RuleFor(a => a.user_password)
                .NotEmpty().WithMessage("Şifre Zorunludur.");
        }
    }
}

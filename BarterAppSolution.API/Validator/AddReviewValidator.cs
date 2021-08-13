using BarterAppSolution.API.Dto;
using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Service;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Validator
{
    public class AddReviewValidator : AbstractValidator<AddUserReviewDto>
    {
        private readonly IUserService userService;

        public AddReviewValidator(IUserService userService)
        {
            this.userService = userService;

            RuleFor(a => a.user_id)
                .NotEmpty().WithMessage("Kullanıcı Id Zorunludur.")
                .Must(IsUserExist).WithMessage("Kullanıcı Sistemde Mevcut Değil.");

            RuleFor(a => a.user_score)
                .NotEmpty().WithMessage("Puan Zorunludur.");

            RuleFor(a => a.notes)
                .MaximumLength(1000).WithMessage("Açıklama Maksimum 1000 Karakter Olmalı.");
        }

        private bool IsUserExist(int userId)
        {
            User user = userService.GetById(userId);
            return user != null;
        }
    }
}

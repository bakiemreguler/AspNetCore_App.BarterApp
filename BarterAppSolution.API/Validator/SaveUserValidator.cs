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
    public class SaveUserValidator : AbstractValidator<AddUserDto>
    {
        private readonly IUserService userService;
        public SaveUserValidator(IUserService userService)
        {
            this.userService = userService;

            RuleFor(a => a.user_mail_address)
                .NotEmpty().WithMessage("Mail Adresi Zorunludur.")
                .MaximumLength(200).WithMessage("Mail Adresi Maksimum 200 Karakter Olmalı.")
                .Must(IsValidMailAddress).WithMessage("Mail Adresi Geçerli Değil.")
                .Must(IsMailAddressNotExist).WithMessage("Mail Adresi Sistemde Mevcut.");

            RuleFor(a => a.user_name)
                .MaximumLength(80).WithMessage("Ad Maksimum 80 Karakter Olmalı.")
                .NotEmpty().WithMessage("Ad Zorunludur.");

            RuleFor(a => a.user_surname)
                .MaximumLength(80).WithMessage("Soyad Maksimum 80 Karakter Olmalı.")
                .NotEmpty().WithMessage("Soyad Zorunludur.");

            RuleFor(a => a.user_is_female)
                .NotNull().WithMessage("Cinsiyet Zorunludur.");

            RuleFor(a => a.user_login_name)
                .MaximumLength(80).WithMessage("Kullanıcı Adı Maksimum 80 Karakter Olmalı.")
                .NotEmpty().WithMessage("Kullanıcı Adı Zorunludur.")
                .Must(IsLoginNameNotExist).WithMessage("Kullanıcı Adı Sistemde Mevcut.");

            RuleFor(a => a.user_login_pass)
                .MaximumLength(1000).WithMessage("Şifre Maksimum 1000 Karakter Olmalı.")
                .NotEmpty().WithMessage("Şifre Zorunludur.");
        }

        private bool IsMailAddressNotExist(string mailAddress)
        {
            User user = userService.GetByFilter(a => a.MailAddress.Trim().ToLower() == mailAddress.Trim().ToLower());
            return user == null;
        }

        private bool IsLoginNameNotExist(string loginName)
        {
            User user = userService.GetByFilter(a => a.LoginName.Trim().ToLower() == loginName.Trim().ToLower());
            return user == null;
        }

        private bool IsValidMailAddress(string mailAddress)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(mailAddress);
                return addr.Address == mailAddress;
            }
            catch
            {
                return false;
            }
        }
    }
}

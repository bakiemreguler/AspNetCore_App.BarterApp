using AutoMapper;
using BarterAppSolution.API.Dto;
using BarterAppSolution.API.ViewModels;
using BarterAppSolution.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddUserDto, User>().
                ForMember(dest => dest.IsFemale, opt => opt.MapFrom(src => src.user_is_female)).
                ForMember(dest => dest.LoginName, opt => opt.MapFrom(src => src.user_login_name)).
                ForMember(dest => dest.LoginPass, opt => opt.MapFrom(src => src.user_login_pass)).
                ForMember(dest => dest.MailAddress, opt => opt.MapFrom(src => src.user_mail_address)).
                ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.user_name)).
                ForMember(dest => dest.ProfilePhoto, opt => opt.MapFrom(src => src.user_profile_photo)).
                ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.user_surname));

            CreateMap<User, ViewUserDto>().
                ForMember(dest => dest.user_id, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.user_role, opt => opt.MapFrom(src => src.UserRole.Role)).
                ForMember(dest => dest.user_name, opt => opt.MapFrom(src => src.Name)).
                ForMember(dest => dest.user_surname, opt => opt.MapFrom(src => src.Surname)).
                ForMember(dest => dest.user_profile_photo, opt => opt.MapFrom(src => src.ProfilePhoto)).
                ForMember(dest => dest.user_is_verified, opt => opt.MapFrom(src => src.IsVerified)).
                ForMember(dest => dest.user_is_female, opt => opt.MapFrom(src => src.IsFemale)).
                ForMember(dest => dest.user_mail_address, opt => opt.MapFrom(src => src.MailAddress));

            CreateMap<AddUserReviewDto, UserReview>().
                ForMember(dest => dest.Explanation, opt => opt.MapFrom(src => src.notes)).
                ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.user_id)).
                ForMember(dest => dest.Score, opt => opt.MapFrom(src => src.user_score));

            CreateMap<UserReview, ViewUserReview>().
                ForMember(dest => dest.notes, opt => opt.MapFrom(src => src.Explanation)).
                ForMember(dest => dest.user_id, opt => opt.MapFrom(src => src.UserId)).
                ForMember(dest => dest.user_name, opt => opt.MapFrom(src => src.User.Name)).
                ForMember(dest => dest.user_surname, opt => opt.MapFrom(src => src.User.Surname)).
                ForMember(dest => dest.user_score, opt => opt.MapFrom(src => src.Score));
        }
    }
}

using AutoMapper;
using MEalAPI.Dto;
using MEalAPI.Models;

namespace MEalAPI
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>().ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}

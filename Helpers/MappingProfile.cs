using AutoMapper;
using MEalAPI.Dto.Requests;
using MEalAPI.Entities;

namespace MEalAPI.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterUserRequest, User>().ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}

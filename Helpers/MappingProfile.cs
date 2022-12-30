using AutoMapper;
using MEalAPI.Dto.Requests;
using MEalAPI.Entities;

namespace MEalAPI.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DRegisterUserRequest, EUser>().ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}

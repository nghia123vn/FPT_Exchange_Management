using AutoMapper;
using FPT_Exchange_Data.DTO.View;
using FPT_Exchange_Data.Entities;

namespace FPT_Exchange_Data.Mapping
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<Role, RoleViewModel>();
        }
    }
}

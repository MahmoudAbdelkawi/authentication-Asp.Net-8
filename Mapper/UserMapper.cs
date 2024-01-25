using AutoMapper;
using CRUD_Operations.Dtos;
using CRUD_Operations.Models;

namespace CRUD_Operations.Mapper
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<RegisterModel, ApplicationUser>();
        }
    }
}

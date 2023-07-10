using AutoMapper;
using TrialsSystem.UsersService.Api.Application.Commands;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Mapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserRequest, CreateUserCommand>();
            CreateMap<UpdateUserRequest, UpdateUserCommand>();
        }
    }
}

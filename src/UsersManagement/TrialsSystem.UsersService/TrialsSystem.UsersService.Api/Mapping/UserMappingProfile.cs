using AutoMapper;
using TrialsSystem.UsersService.Api.Application.Commands;
using TrialsSystem.UsersService.Api.Application.Commands.City;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Mapping;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<CreateUserRequest, CreateUserCommand>();
        CreateMap<UpdateUserRequest, UpdateUserCommand>();

        CreateMap<CreateCityRequest, CreateCityCommand>();
        CreateMap<UpdateCityRequest, UpdateCityCommand>();
    }
}

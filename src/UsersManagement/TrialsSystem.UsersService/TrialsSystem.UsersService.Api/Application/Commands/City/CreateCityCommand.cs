using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City;

public record CreateCityCommand(string Name) : IRequest<CityResponse>;

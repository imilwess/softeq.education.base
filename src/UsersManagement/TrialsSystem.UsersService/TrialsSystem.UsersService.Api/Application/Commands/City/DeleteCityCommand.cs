using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands.City;

public record DeleteCityCommand(string Id) : IRequest<string>;
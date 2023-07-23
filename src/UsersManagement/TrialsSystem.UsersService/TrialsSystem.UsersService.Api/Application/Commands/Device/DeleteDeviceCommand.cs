using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device;

public record DeleteDeviceCommand(string Id) : IRequest<string>;
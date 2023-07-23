using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device;

public record GetDeviceByIdQuery(string Id) : IRequest<DeviceResponse>;

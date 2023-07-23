using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device;

public record GetDevicesQuery(int? Skip, int? Take) : IRequest<IEnumerable<DeviceResponse>>;

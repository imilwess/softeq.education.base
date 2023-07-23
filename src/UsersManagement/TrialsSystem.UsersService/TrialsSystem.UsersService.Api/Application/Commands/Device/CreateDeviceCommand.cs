using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device;

public record CreateDeviceCommand(
    string SerialNumber,
    string Model,
    string DeviceTypeId,
    string FirmwareVersion
) : IRequest<DeviceResponse>;

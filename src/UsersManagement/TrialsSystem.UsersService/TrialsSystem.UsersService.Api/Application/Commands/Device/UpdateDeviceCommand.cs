using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device;

public record UpdateDeviceCommand(
    string Id, 
    string SerialNumber, 
    string Model, 
    DeviceTypeDto Type, 
    string FirmwareVersion
) : IRequest<DeviceResponse>;
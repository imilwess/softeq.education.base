using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device;

public class CreateDeviceCommandHandler : IRequestHandler<CreateDeviceCommand, DeviceResponse>
{
    public async Task<DeviceResponse> Handle(CreateDeviceCommand request, CancellationToken cancellationToken)
    {
        return new DeviceResponse(string.Empty, string.Empty, string.Empty, new DeviceTypeDto(string.Empty, string.Empty), string.Empty);
    }
}

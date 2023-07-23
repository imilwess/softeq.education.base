using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device;

public class GetDeivceByIdQueryHandler : IRequestHandler<GetDeviceByIdQuery, DeviceResponse>
{
    public async Task<DeviceResponse> Handle(GetDeviceByIdQuery request, CancellationToken cancellationToken)
    {
        return new DeviceResponse(string.Empty, string.Empty, string.Empty, new DeviceTypeDto(string.Empty, string.Empty), string.Empty);
    }
}

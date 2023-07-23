using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device;

public class GetDevicesQueryHandler : IRequestHandler<GetDevicesQuery, IEnumerable<DeviceResponse>>
{
    public GetDevicesQueryHandler() {}

    public async Task<IEnumerable<DeviceResponse>> Handle(GetDevicesQuery request, CancellationToken cancellationToken)
    {
        return Enumerable.Empty<DeviceResponse>();
    }
}

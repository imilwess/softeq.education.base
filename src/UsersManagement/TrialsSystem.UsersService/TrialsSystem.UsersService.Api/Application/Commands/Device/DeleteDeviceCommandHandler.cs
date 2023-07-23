using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device;

public class DeleteDeviceCommandHandler : IRequestHandler<DeleteDeviceCommand, string>
{
    public async Task<string> Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
    {
        return request.Id;
    }
}

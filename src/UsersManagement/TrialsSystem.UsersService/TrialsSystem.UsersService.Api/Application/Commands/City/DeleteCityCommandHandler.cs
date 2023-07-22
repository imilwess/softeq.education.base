using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands.City;

public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, string>
{
    public async Task<string> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
    {
        return request.Id;
    }
}

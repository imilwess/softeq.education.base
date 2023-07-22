using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City;

public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, CityResponse>
{
    public async Task<CityResponse> Handle(CreateCityCommand request, CancellationToken cancellationToken)
    {
        return new CityResponse(string.Empty, string.Empty);
    }
}

using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City;

public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, CityResponse>
{
    public async Task<CityResponse> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
    {
        return new CityResponse(string.Empty, string.Empty);
    }
}

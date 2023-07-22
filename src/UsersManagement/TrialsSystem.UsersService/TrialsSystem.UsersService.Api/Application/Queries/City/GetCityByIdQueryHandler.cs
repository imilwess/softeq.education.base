using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City;

public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, CityResponse>
{
    public GetCityByIdQueryHandler() {}

    public async Task<CityResponse> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
    {
        return new CityResponse(string.Empty, string.Empty);
    }
}

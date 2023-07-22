using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City;

public class GetCitiesQueryHandler : IRequestHandler<GetCitiesQuery, IEnumerable<CityResponse>>
{
    public GetCitiesQueryHandler() {}

    public async Task<IEnumerable<CityResponse>> Handle(GetCitiesQuery request, CancellationToken cancellationToken)
    {
        return Enumerable.Empty<CityResponse>();
    }
}

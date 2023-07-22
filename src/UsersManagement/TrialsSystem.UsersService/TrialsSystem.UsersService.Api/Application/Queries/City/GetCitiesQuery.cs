using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City;

public class GetCitiesQuery : IRequest<IEnumerable<CityResponse>>
{
    public GetCitiesQuery(int? skip, int? take)
    {
        Skip = skip;
        Take = take;
    }

    public int? Skip { get; }
    public int? Take { get; }
}

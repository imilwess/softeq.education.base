using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City;

public class GetCityByIdQuery : IRequest<CityResponse>
{
    public GetCityByIdQuery(string id)
    {
        Id = id;
    }

    public string Id { get; }
}

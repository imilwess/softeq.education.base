using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class UsersQuery : IRequest<IEnumerable<GetUsersResponse>>
    {
        public UsersQuery(int? take, int? skip, string? email)
        {
            Take = take;
            Skip = skip;
            Email = email;
        }

        public int? Take { get; }
        public int? Skip { get; }
        public string? Email { get; }
    }
}

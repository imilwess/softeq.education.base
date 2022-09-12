using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class UsersQueryHandler : IRequestHandler<UsersQuery, GetUsersResponse>
    {
        public UsersQueryHandler()
        {

        }

        public Task<GetUsersResponse> Handle(UsersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

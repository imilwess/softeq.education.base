using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class UserQueryHandler : IRequestHandler<UserQuery, GetUserResponse>
    {
        public async Task<GetUserResponse> Handle(UserQuery request, CancellationToken cancellationToken)
        {
            var user = new GetUserResponse
            {
                Name = request.UserId
            };

            return user;
        }
    }
}

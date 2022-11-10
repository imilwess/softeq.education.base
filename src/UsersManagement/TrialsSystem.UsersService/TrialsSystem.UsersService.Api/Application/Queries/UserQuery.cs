using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class UserQuery : IRequest<GetUserResponse>
    {
        public string UserId { get; set; }

        public UserQuery(string userId)
        {
            UserId = userId;
        }
    }
}

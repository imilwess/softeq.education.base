using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class GetUserByIdQuery : IRequest<GetUserByIdResponse>
    {
        public GetUserByIdQuery(string userId)
        {
            UserId = userId;
        }

        public string UserId { get; }
    }
}

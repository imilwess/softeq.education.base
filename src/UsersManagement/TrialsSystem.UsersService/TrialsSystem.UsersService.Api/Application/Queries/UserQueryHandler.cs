using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.BaseDTO;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class UserQueryHandler : IRequestHandler<GetUserByIdQuery, GetUserByIdResponse>
    {
        public async Task<GetUserByIdResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = new GetUserByIdResponse(string.Empty, string.Empty, string.Empty, DateTime.Now, 0, 0, 
                new IdNameDto(string.Empty, string.Empty),
                new IdNameDto(string.Empty, string.Empty));

            return user;
        }
    }
}

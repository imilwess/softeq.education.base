using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UpdateUserResponse>
    {
        public async Task<UpdateUserResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var updatedUser = new UpdateUserResponse(
                string.Empty, request.Name, request.Surname, request.BirthDate, request.Weight, request.Height, request.CityId);

            return updatedUser;
        }
    }
}

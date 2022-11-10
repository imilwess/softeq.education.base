using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UpdateUserResponse>
    {
        public async Task<UpdateUserResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var updatedUser = new UpdateUserResponse
            {
                Name = request.Name,
                Surname = request.Surname,
                BirthDate = request.BirthDate,
                CityId = request.CityId,
                Height = request.Height,
                Id = request.Id,
                Weight = request.Weight,
            };

            return updatedUser;
        }
    }
}

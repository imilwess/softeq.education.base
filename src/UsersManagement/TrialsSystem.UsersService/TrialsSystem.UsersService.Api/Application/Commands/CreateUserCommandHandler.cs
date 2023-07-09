using System.Reflection.Metadata.Ecma335;
using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserResponse>
    {
        public CreateUserCommandHandler()
        {

        }

        public async Task<CreateUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return new CreateUserResponse(string.Empty, request.Email, request.Name, request.Surname, request.BirthDate, request.Weight,request.Height, request.CityId, request.GenderId);
        }
    }
}

using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class DeleteUserCommand : IRequest<string>
    {
        public string Id { get; set; }

        public DeleteUserCommand(string id)
        {
            Id = id;
        }
    }
}

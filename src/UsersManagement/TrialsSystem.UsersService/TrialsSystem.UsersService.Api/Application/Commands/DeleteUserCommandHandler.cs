using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, string>
    {
        public async Task<string> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return request.Id;
        }
    }
}

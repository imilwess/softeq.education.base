using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Validation
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(u => u.Email)
                .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
                .WithMessage("The Email is not valid.");
            RuleFor(u => u.BirthDate)
                .Must(u => u < DateTime.Now.AddYears(-18)).WithMessage("The participant should be older than 18 years.");
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("The name can't be empty.");
            RuleFor(u => u.Surname)
                .NotEmpty().WithMessage("The surname can't be empty.")
                .NotEqual(u => u.Name).WithMessage("Name can't be equal to surname.");
        }
    }
}

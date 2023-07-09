namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

public class CreateUserResponse : CreateUserRequest
{
    public string Id { get; }

    public CreateUserResponse(string id, string email, string name, string surname, DateTime birthDate, decimal? weight, decimal? height, string cityId, string genderId)
        : base(email, name, surname, birthDate, weight, height, cityId, genderId)
    {
        Id = id;
    }
}
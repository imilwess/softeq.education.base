namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs
{
    public class CreateUserRequest
    {
        public CreateUserRequest(string email, string name, string surname, DateTime birthDate, decimal? weight, decimal? height, string cityId, string genderId)
        {
            Email = email;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
            CityId = cityId;
            GenderId = genderId;
        }

        public string Email { get; }
        public string Name { get; }
        public string Surname { get; }
        public DateTime BirthDate { get; }
        public decimal? Weight { get; }
        public decimal? Height { get; }
        public string CityId { get; }
        public string GenderId { get; }
    }
}

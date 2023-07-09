namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs
{
    public class GetUsersResponse
    {
        public GetUsersResponse(string email, string name, string surname, DateTime birthDate, decimal? weight, decimal? height, string cityName, string genderName)
        {
            Email = email;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
            CityName = cityName;
            GenderName = genderName;
        }

        public string Email { get; }
        public string Name { get; }
        public string Surname { get; }
        public DateTime BirthDate { get; }
        public decimal? Weight { get; }
        public decimal? Height { get; }
        public string CityName { get; }
        public string GenderName { get; }
    }
}

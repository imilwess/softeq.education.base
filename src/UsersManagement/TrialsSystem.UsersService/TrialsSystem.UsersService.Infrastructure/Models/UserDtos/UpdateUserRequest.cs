namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs
{
    public class UpdateUserRequest
    {
        public UpdateUserRequest(string name, string surname, DateTime birthDate, decimal? weight, decimal? height, string cityId)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
            CityId = cityId;
        }

        public string Name { get; }
        public string Surname { get; }
        public DateTime BirthDate { get; }
        public decimal? Weight { get; }
        public decimal? Height { get; }
        public string CityId { get; }
    }
}

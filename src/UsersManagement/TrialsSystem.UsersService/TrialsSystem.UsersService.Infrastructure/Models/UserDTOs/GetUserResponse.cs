using TrialsSystem.UsersService.Infrastructure.Models.BaseDTO;

namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs
{
    public class GetUserByIdResponse
    {
        public GetUserByIdResponse(string email, string name, string surname, DateTime birthDate, decimal? weight, decimal? height, IdNameDto city, IdNameDto gender)
        {
            Email = email;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
            City = city;
            Gender = gender;
        }

        public string Email { get; }
        public string Name { get; }
        public string Surname { get; }
        public DateTime BirthDate { get; }
        public decimal? Weight { get; }
        public decimal? Height { get; }
        public IdNameDto City { get; }
        public IdNameDto Gender { get; }
    }
}

namespace TrialsSystem.UsersService.Infrastructure.Models.BaseDTO
{
    public class IdNameDto
    {
        public IdNameDto(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; }
        public string Name { get; }
    }
}

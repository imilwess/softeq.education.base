using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialsSystem.UsersService.Domain.AggregatesModel.Base;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.UserAggregate
{
    public class User : Entity
    {
        public User(string email, string name, string surname, string cityd, DateTime birthDate)
        {

            Email = email;
            Name = name;
            Surname = surname;
            CityId = cityd;
            BirthDate = BirthDate;
        }

        public string Email { get; private set; }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        private string CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; private set; }

        public DateTime BirthDate { get; private set; }

    }
}

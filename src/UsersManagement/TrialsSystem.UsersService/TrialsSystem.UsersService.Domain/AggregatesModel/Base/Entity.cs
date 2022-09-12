using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.Base
{
    public class Entity
    {
        public string Id { get; protected set; }
        public bool IsDeleted { get; protected set; }

        public DateTime CreatedDate { get; protected set; }
        public string CreatedBy { get; protected set; }

        public DateTime LastModifiedDateDate { get; protected set; }

    }
}

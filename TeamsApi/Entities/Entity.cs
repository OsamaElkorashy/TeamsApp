using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamsApi.Entities
{
    public class Entity
    {
        public Entity()
        {
            CreationDate = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModificationDate { get; set; }

    }
}

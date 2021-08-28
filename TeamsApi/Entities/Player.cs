using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamsApi.Entities
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nationaity { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
    }
}

using System;

namespace TeamsApi.ViewModels
{
    public class GetPlayerViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nationaity { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using TeamsApi.Entities;

namespace TeamsApi
{
    public class TeamsContext : DbContext
    {
        public TeamsContext(
    DbContextOptions options) : base(options)
        {
        }
        DbSet<Player> players { get; set; }
        DbSet<Team> teams { get; set; }
    }
}

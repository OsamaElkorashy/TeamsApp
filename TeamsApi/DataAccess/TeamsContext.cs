using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeamsApi.Entities;

namespace TeamsApi
{
    public class TeamsContext : IdentityDbContext<User>
    {
        public TeamsContext(DbContextOptions<TeamsContext> options) : base(options)
        {
        }
        DbSet<Player> players { get; set; }
        DbSet<Team> teams { get; set; }
    }
}

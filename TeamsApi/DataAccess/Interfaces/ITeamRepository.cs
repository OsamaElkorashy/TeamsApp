using System.Linq;
using System.Threading.Tasks;
using TeamsApi.Entities;

namespace TeamsApi.DataAccess.Interfaces
{
    public interface ITeamRepository
    {
        IQueryable<Team> GetAll();
        void Add(Team team);
        void Update(Team entity);
        void Delete(Team entity);
        Task<int> SaveChanges();
    }
}

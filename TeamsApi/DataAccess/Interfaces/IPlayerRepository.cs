using System.Linq;
using System.Threading.Tasks;
using TeamsApi.Entities;

namespace TeamsApi.DataAccess.Interfaces
{
    public interface IPlayerRepository
    {
        void Update(Player entity);
        void Delete(Player entity);
        Task<int> SaveChanges();
        IQueryable<Player> GetAll();
    }
}

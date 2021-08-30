using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TeamsApi.DataAccess.Interfaces
{

    public interface IUnitOfWork
    {
        DbSet<TEntity> CreateSet<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}

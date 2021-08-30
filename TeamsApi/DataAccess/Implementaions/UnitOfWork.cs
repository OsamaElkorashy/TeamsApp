using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;
using TeamsApi.DataAccess.Interfaces;

namespace TeamsApi.DataAccess.Implementations
{
    public class UnitOfWork:IUnitOfWork
    {
        #region Members

        private readonly TeamsContext _context;


        #endregion

        #region Constructor

        public UnitOfWork(TeamsContext context)
        {
            _context = context;
        }

        #endregion

        #region IUnitOfWork Members     

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public int SaveChanges()
        {
            return  _context.SaveChanges();
        }

        public DbSet<TEntity> CreateSet<TEntity>()
            where TEntity : class
        {
            var set = _context.Set<TEntity>();
            return set;
        }

        #endregion

    }
}


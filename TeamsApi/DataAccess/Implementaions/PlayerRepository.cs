using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsApi.DataAccess.Interfaces;
using TeamsApi.Entities;

namespace TeamsApi.DataAccess.Implementations
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlayerRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<int> SaveChanges()
        {
            return await _unitOfWork.SaveChangesAsync();
        }
        public void Update(Player player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("entity");
            }
            var dbSet = _unitOfWork.CreateSet<Player>();
            dbSet.Update(player);
        }
        public void Delete(Player player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("entity");
            }
            var dbSet = _unitOfWork.CreateSet<Player>();
            dbSet.Remove(player);
        }
        public IQueryable<Player> GetAll()
        {
            return _unitOfWork.CreateSet<Player>();
        }
    }
}

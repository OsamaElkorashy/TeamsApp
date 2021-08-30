using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsApi.DataAccess.Interfaces;
using TeamsApi.Entities;

namespace TeamsApi.DataAccess.Implementations
{
    public class TeamRepository : ITeamRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeamRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<int> SaveChanges()
        {
            return await _unitOfWork.SaveChangesAsync();
        }

        public IQueryable<Team> GetAll()
        {
            return _unitOfWork.CreateSet<Team>();
        }

        public void Add(Team team)
        {
            if (team == null)
            {
                throw new ArgumentNullException("entity");
            }

            var dbSet = _unitOfWork.CreateSet<Team>();
            dbSet.Add(team);

        }
        public void Update(Team team)
        {
            if (team == null)
            {
                throw new ArgumentNullException("entity");
            }
            var dbSet = _unitOfWork.CreateSet<Team>();
            dbSet.Update(team);
        }
        public void Delete(Team team)
        {
            if (team == null)
            {
                throw new ArgumentNullException("entity");
            }
            RemoveChildren(team.players);
            var dbSet = _unitOfWork.CreateSet<Team>();
            dbSet.Remove(team);
        }
        private void RemoveChildren(ICollection<Player> players)
        {
            var dbset = _unitOfWork.CreateSet<Player>();
            dbset.RemoveRange(players);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsApi.Entities;
using TeamsApi.ViewModels;

namespace TeamsApi.Service.Interfaces
{
   public interface IPlayerBussiness
    {
        IQueryable<Player> GetAllPlayers();
        List<GetPlayerViewModel> GetPlayersByTeamId(Guid teamId);
        Task<bool> UpdatePlayer(Player player);
        Task<bool> DeletePlayer(Guid Id);
    }
}


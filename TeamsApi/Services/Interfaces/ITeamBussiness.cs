using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamsApi.Entities;
using TeamsApi.ViewModels;

namespace TeamsApi.Service.Interfaces
{
   public interface ITeamBussiness
    {
        Task<Guid> AddNewTeam(AddTeamViewModel team);
        Team GetTeamById(Guid teamId);

        Task<bool> UpdateTeam(Team team);
        Task<bool> DeleteTeam(Guid Id);
        List<GetTeamViewModel> GetAllTeams();
    }
}


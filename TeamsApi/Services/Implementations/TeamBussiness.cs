using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsApi.DataAccess.Implementations;
using TeamsApi.DataAccess.Interfaces;
using TeamsApi.Entities;
using TeamsApi.Service.Interfaces;
using TeamsApi.ViewModels;

namespace TeamsApi.Service.Implementation
{
    public class TeamBussiness : ITeamBussiness
    {
        readonly private ITeamRepository _teamRepository;
        readonly private IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;
        public TeamBussiness(ITeamRepository teamRepository, IMapper mapper, IPlayerRepository playerRepository)
        {
            _teamRepository = teamRepository;
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
        public async Task<Guid> AddNewTeam(AddTeamViewModel teamViewModel)
        {
            Team team = _mapper.Map<Team>(teamViewModel);
            team.Id = Guid.NewGuid();
            _teamRepository.Add(team);
            int added = await _teamRepository.SaveChanges();
            if (added > 0)
                return await Task.FromResult(team.Id);
            else
                throw new Exception("Not Saved") ;
        }

        public async Task<bool> DeleteTeam(Guid Id)
        {
           Team team = _teamRepository.GetAll().Include(t=>t.players).Where(t => t.Id == Id).FirstOrDefault();
            _teamRepository.Delete(team);
            int deleted = await _teamRepository.SaveChanges();
            if (deleted > 0)
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);
        }

        public List<GetTeamViewModel> GetAllTeams()
        {
            var TeamsList = _teamRepository.GetAll();
            return _mapper.Map<List<GetTeamViewModel>>(TeamsList);
        }
        public Team GetTeamById(Guid teamId)
        {
            return _teamRepository.GetAll()
               .Include(a => a.players)
               .Where(e => e.Id == teamId)
                .FirstOrDefault();
        }

        public async Task<bool> UpdateTeam(Team request)
        {
            //var team = _teamRepository.GetAll().Include(t=>t.players).Where(t => t.Id == request.Id).FirstOrDefault();
            //foreach (var player in team.players)
            //{
            //    _playerRepository.Delete(player);
            //}
           _teamRepository.Update(request);
            int added = await _teamRepository.SaveChanges();
            if (added > 0)
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);

        }


    }
}

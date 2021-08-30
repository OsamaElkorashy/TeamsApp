using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsApi.DataAccess.Interfaces;
using TeamsApi.Entities;
using TeamsApi.Service.Interfaces;
using TeamsApi.ViewModels;

namespace TeamsApi.Service.Implementation
{
    public class PlayerBussiness : IPlayerBussiness
    {
        readonly private IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;
        public PlayerBussiness(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<bool> DeletePlayer(Guid Id)
        {
           Player Player = _playerRepository.GetAll().Where(t => t.Id == Id).FirstOrDefault();
            _playerRepository.Delete(Player);
            int deleted = await _playerRepository.SaveChanges();
            if (deleted > 0)
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);
        }

        public IQueryable<Player> GetAllPlayers()
        {
            return _playerRepository.GetAll();
        }

        public List<GetPlayerViewModel> GetPlayersByTeamId(Guid teamId)
        {
            var playersList = _playerRepository.GetAll().Where(t=>t.TeamId== teamId).ToList();
            return _mapper.Map<List<GetPlayerViewModel>>(playersList);
        }

        public async Task<bool> UpdatePlayer(Player request)
        {
            _playerRepository.Update(request);
            int added = await _playerRepository.SaveChanges();
            if (added > 0)
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);

        }


    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TeamsApi.Entities;
using TeamsApi.Service.Implementation;
using TeamsApi.Service.Interfaces;
using TeamsApi.ViewModels;
using static TeamsApi.Constants.Authorization;

namespace TeamsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        private readonly IPlayerBussiness _playerBussiness;
        public PlayerController(IPlayerBussiness playerBussiness)
{
            _playerBussiness = playerBussiness;
        }
        // GET: api/<TeamsController>
        [HttpGet]
        [Authorize(Roles = "User,Admin")]
        public List<Player> Get()
        {
            return _playerBussiness.GetAllPlayers().ToList();
        }

        // GET api/<TeamsController>/5
        [HttpGet("{teamId}")]
        [Authorize(Roles = "User,Admin")]
        public List<GetPlayerViewModel> GetbyTeamId(Guid teamId)
        {
            return _playerBussiness.GetPlayersByTeamId(teamId);
        }

        // PUT api/<TeamsController>/5
        [HttpPut]
        [Authorize(Roles = "Admin")]
        public bool Put([FromBody] Player player)
        {
          return _playerBussiness.UpdatePlayer(player).Result;
        }

        // DELETE api/<TeamsController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public bool Delete(Guid id)
        {
           return _playerBussiness.DeletePlayer(id).Result;
        }
    }
}

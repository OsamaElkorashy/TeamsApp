using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TeamsApi.Entities;
using TeamsApi.Service.Interfaces;
using TeamsApi.ViewModels;
using static TeamsApi.Constants.Authorization;

namespace TeamsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {

        private readonly ITeamBussiness _teamBussiness;
        public TeamController(ITeamBussiness teamBussiness)
{
            _teamBussiness = teamBussiness;
        }
        // GET: api/<TeamsController>
        [HttpGet]
        [Authorize(Roles = "User,Admin")]
        public List<GetTeamViewModel> Get()
        {
            return _teamBussiness.GetAllTeams();
        }

        // GET api/<TeamsController>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "User,Admin")]
        public Team Get(Guid id)
        {
            return _teamBussiness.GetTeamById(id);
        }

        // POST api/<TeamsController>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public Guid Post([FromBody] AddTeamViewModel teamViewModel)
        {
            return _teamBussiness.AddNewTeam(teamViewModel).Result;
        }

        // PUT api/<TeamsController>/5
        [HttpPut]
        [Authorize(Roles = "Admin")]
        public bool Put([FromBody] Team team)
        {
          return  _teamBussiness.UpdateTeam(team).Result;
        }

        // DELETE api/<TeamsController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public bool Delete(Guid id)
        {
           return _teamBussiness.DeleteTeam(id).Result;
        }
    }
}

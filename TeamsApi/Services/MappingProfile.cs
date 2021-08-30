using AutoMapper;
using System;
using TeamsApi.Entities;
using TeamsApi.ViewModels;

namespace TeamsApi.Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<AddTeamViewModel, Team>();
            CreateMap<Team, GetTeamViewModel>();
            CreateMap<Player, GetPlayerViewModel>();
        }
    }
}

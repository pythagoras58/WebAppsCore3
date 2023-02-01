using AutoMapper;
using WebAppsCore3.DTOs;
using WebAppsCore3.Models;

namespace WebAppsCore3.Profiles
{
    public class CommandsProfile : Profile
    {
        
        public CommandsProfile() 
        {
            CreateMap<Command, CommandReadDTO>();

            CreateMap<CommandCreateDTO, Command>();

            CreateMap<CommandUpdateDTO, Command>();

            CreateMap<Command, CommandUpdateDTO>();
        }
    }
}

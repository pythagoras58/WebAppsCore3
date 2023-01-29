using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppsCore3.Data;
using WebAppsCore3.DTOs;
using WebAppsCore3.Models;

namespace WebAppsCore3.Controllers
{
    [Route("api/commands")]    
    [ApiController]
    public class CommandsController : ControllerBase
    {
        // Using DI
        private readonly ICommanderRepo _respository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo resitory, IMapper mapper) { 
            _respository= resitory;
            _mapper = mapper;
        }
        
        //private readonly MockCommanderRepo _commanderRepo = new MockCommanderRepo();// make an instance of the repo

        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult <IEnumerable<CommandReadDTO>> GetAllCommands() {
            //use repository to pull the data
            var commands = _respository.GetAppCommands();
            if(commands == null)
            {
                return NoContent();
            }

            return  Ok(_mapper.Map<IEnumerable<CommandReadDTO>>(commands));
        }


        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult <CommandReadDTO> GetCommandById(int id)
        {
            var command = _respository.GetCommandById(id);
            if (command == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CommandReadDTO>(command));
        }


        // POST
        [HttpPost]
        public ActionResult<CommandCreateDTO> CreateCommand(CommandCreateDTO commandCreateDTO) 
        {
            var  commandModel = _mapper.Map<Command>(commandCreateDTO);

            _respository.CreateCommand(commandModel);
            _respository.SaveChanges();

            var commandReadDTO = _mapper.Map<CommandReadDTO>(commandModel);

            // use createdAt Route
            return CreatedAtRoute(nameof(GetCommandById), new {Id = commandReadDTO.Id}, commandReadDTO);
           // return Ok(commandReadDTO);
        }
    }
}

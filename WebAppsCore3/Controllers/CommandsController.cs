using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppsCore3.Data;
using WebAppsCore3.Models;

namespace WebAppsCore3.Controllers
{
    [Route("api/commands")]    
    [ApiController]
    public class CommandsController : ControllerBase
    {
        // Using DI
        private readonly ICommanderRepo _respository;
        public CommandsController(ICommanderRepo resitory) { 
            _respository= resitory;
        }
        
        //private readonly MockCommanderRepo _commanderRepo = new MockCommanderRepo();// make an instance of the repo

        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult <IEnumerable<Command>> GetAllCommands() {
            //use repository to pull the data
            var commands = _respository.GetAppCommands();
            if(commands == null)
            {
                return NoContent();
            }

            return  Ok(commands);
        }


        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var command = _respository.GetCommandById(id);
            if (command == null)
            {
                return NotFound();
            }

            return Ok(command);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppsCore3.Data;
using WebAppsCore3.Models;

namespace WebAppsCore3.Controllers
{
    [Route("api/[controller]")]    
    [ApiController]
    public class CommandsController : ControllerBase
    {
        // make an instance of the repo
        private readonly MockCommanderRepo _commanderRepo = new MockCommanderRepo();

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands() {
            //use repository to pull the data
            return null;
        }


        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            return null;
        }
    }
}

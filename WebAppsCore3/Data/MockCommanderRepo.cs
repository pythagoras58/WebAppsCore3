using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using WebAppsCore3.Models;


namespace WebAppsCore3.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command { Id = 1, HowTo = "Write Code", Line = "Get laptop", Platform = "Windows" },
                new Command { Id = 2, HowTo = "Write Code", Line = "Get laptop", Platform = "Apple" },
                new Command { Id = 3, HowTo = "Write Code", Line = "Get laptop", Platform = "Linux" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = id, HowTo = "Write Code", Line = "Get laptop", Platform = "Windows" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}

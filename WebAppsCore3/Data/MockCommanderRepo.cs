using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using WebAppsCore3.Models;


namespace WebAppsCore3.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Write Code", Line = "Get laptop", Platform = "Windows" };
        }
    }
}

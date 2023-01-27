using System.Collections.Generic;
using WebAppsCore3.Models;

namespace WebAppsCore3.Data
{
    public class MockCommanderRepo : ICommanderInterface
    {
        public IEnumerable<Command> GetAppCommands()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}

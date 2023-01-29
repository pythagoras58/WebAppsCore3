using System.Collections.Generic;
using WebAppsCore3.Models;

namespace WebAppsCore3.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int id);

        void CreateCommand(Command command);
    }
}

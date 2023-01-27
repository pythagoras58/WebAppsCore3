using System.Collections.Generic;
using WebAppsCore3.Models;

namespace WebAppsCore3.Data
{
    public interface ICommanderInterface
    {
        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int id);
    }
}

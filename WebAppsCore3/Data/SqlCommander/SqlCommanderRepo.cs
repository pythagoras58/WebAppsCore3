using System.Collections.Generic;
using System.Linq;
using WebAppsCore3.Models;

namespace WebAppsCore3.Data.SqlCommander
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
                _context = context;
        }
        public IEnumerable<Command> GetAppCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
           return _context.Commands.FirstOrDefault(c => c.Id == id);
        }
    }
}

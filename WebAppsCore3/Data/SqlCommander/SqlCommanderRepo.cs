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

        public void CreateCommand(Command command)
        {
            // check for errors
            if(command == null)
            {
                throw new System.ArgumentNullException(nameof(command));
            }

            _context.Commands.Add(command);
        }

        public IEnumerable<Command> GetAppCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
           return _context.Commands.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void SoftDeleteCommand(Command command)
        {
            if(command == null )
            {
                throw new System.ArgumentNullException(nameof(command));
            }
            _context.Commands.Remove(command);
        }

        public void UpdateCommand(Command command)
        {
            // do nothing
        }
    }
}

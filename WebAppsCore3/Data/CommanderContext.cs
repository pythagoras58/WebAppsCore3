using Microsoft.EntityFrameworkCore;
using WebAppsCore3.Models;

namespace WebAppsCore3.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt) 
        {
                
        }

        //create a representation of the Db
        public DbSet<Command> Commands { get; set; }    
    }
}

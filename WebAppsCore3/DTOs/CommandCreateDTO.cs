using System.ComponentModel.DataAnnotations;

namespace WebAppsCore3.DTOs
{
    public class CommandCreateDTO 
    {   
        public string HowTo { get; set; }

        public string Line { get; set; }

        public string Platform { get; set; }
    }
}

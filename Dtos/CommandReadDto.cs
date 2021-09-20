using CommandsService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsService.Dtos
{
    public class CommandReadDto
    {
 
        public int Id { get; set; }
  
        public string HowTo { get; set; }

        public string CommandLine { get; set; }
    
        public int PlatformId { get; set; }

    }
}

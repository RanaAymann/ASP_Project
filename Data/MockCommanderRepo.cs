using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command { id = 1, HowTo = "by Code 1", Line = "water 1", Platform = "choose it!" },
                new Command { id = 2, HowTo = "by Code 2", Line = "water 2", Platform = "choose it!" },
                new Command { id = 3, HowTo = "by Code 3", Line = "water 3", Platform = "choose it!" },
                new Command { id = 4, HowTo = "by Code 4", Line = "water 4", Platform = "choose it!" }

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { id = 0, HowTo = "by Code", Line = "water", Platform = "choose it!" };
        }
    }
}
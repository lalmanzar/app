using System.Collections.Generic;
using System.Linq;

namespace app.web.core
{
    public class CommandRegistry : IFindCommands
    {
        readonly IEnumerable<IProcessASingleRequest> all_the_commands;

        public CommandRegistry(IEnumerable<IProcessASingleRequest> allTheCommands)
        {
            all_the_commands = allTheCommands;
        }

        public IProcessASingleRequest get_the_command_that_can_process(IProvideDetailsToCommands the_request)
        {
            return all_the_commands.First(x => x.can_process(the_request));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooibos.RC.IO.Commands
{
    public class ECHO : RCCommandBase<string>
    {
        public const string Command = "ECHO";

        public override string GetCommand()
        {
            return Command;
        }
    }
}

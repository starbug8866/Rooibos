using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooibos.RC.IO.Commands
{
    public class RSET : RCCommandBase<string>
    {
        public const string Command = "RSET";

        public override string GetCommand()
        {
            return Command;
        }
    }
}

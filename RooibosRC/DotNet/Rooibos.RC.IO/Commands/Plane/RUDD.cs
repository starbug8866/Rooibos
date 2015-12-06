using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooibos.RC.IO.Commands.Plane
{
    public class RUDD : RCCommandBase<int>
    {
        public const string Command = "RUDD";

        public override string GetCommand()
        {
            return Command;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooibos.RC.IO.Commands.Plane
{
    public class POWR : RCCommandBase<int>
    {
        public const string Command = "POWR";

        public override string GetCommand()
        {
            return Command;
        }
    }
}

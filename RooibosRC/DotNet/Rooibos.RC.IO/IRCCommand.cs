using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooibos.RC.IO
{
    public interface IRCCommand<T>
    {
        string GetCommand();
        string GetValue();
        T Value {get;set;}
    }
}

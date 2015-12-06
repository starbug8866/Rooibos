using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rooibos.RC.IO
{
    public class Test
    {
        public bool Stop { get; set; }

        public void BeginTest(int timeBetweenCommandsMS, RCBridge bridge ,List<string[]> commands)
        {       
            DateTime lastTest = DateTime.Now;

            int idx = 0;

            while(Stop == false)
            {
                if ((DateTime.Now - lastTest).Milliseconds >= timeBetweenCommandsMS)
                {
                    string key = commands[idx][0];
                    var value = commands[idx][1];
                    bridge.SendCommand(key, value);

                    lastTest = DateTime.Now;

                    idx++;

                    if (idx == commands.Count)
                    {
                        idx = 0;
                    }
                }
            }
        }
    }
}

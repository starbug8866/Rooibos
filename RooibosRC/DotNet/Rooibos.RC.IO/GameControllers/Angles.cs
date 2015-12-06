using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooibos.RC.IO.GameControllers
{
    public class Angles
    {
        public int Ailerons = 90;
        public int Elevators = 90;
        public int Rudder = 90;

        public Angles(int ailerons, int elevators, int rudder)
        {
            Ailerons = ailerons;
            Elevators = elevators;
            Rudder = rudder;
        }
    }
}

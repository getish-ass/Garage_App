using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class MotorCycle : Vehicle
    {
        double CylVol { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Cylinder Vol.: {CylVol}";
        }

    }
}

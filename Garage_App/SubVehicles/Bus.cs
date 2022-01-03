using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class Bus : Vehicle
    {
        public Bus(string regnr, string color, int nrofWheels, int numofSeats) : base(regnr, color, nrofWheels)
        {
            NumOfSit = numofSeats;
        }

        public int NumOfSit { get; set; }


        public override string ToString()
        {
            return $"{base.ToString()}, Number Of Sit: {NumOfSit}.";
        }
    }
}

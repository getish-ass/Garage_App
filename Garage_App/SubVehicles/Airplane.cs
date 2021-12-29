using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class Airplane : Vehicle
    {
        int NumberOfEngines { get; set; }  
        int NumberOfSit { get; set; }   
        double Length { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Number Of Eng.: {NumberOfEngines} Number Of Sit: {NumberOfSit} Length: {Length}";
        }

    }
}

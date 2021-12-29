using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class Garage<T> where T : Vehicle

    {
        public T[] ts;
        int count = -1;

        public Garage(int i)
        {
            ts = new T[i];
        }
        public void Add(T t) { ts[++count] = t; }

        public void DesplayVehicle()
        {
            foreach (T t in ts)
            { 
              //handles unassigned null array members 
                if (t != null)
                {
                    Console.WriteLine(t.ToString());
                }
                else
                {
                    break;
                }
            }
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle

    {
        private T[] vehicles;

        public Garage(int i)
        {
            vehicles = new T[i];
        }

        public bool Park(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
            }
            return false;
        }

        public bool Unpark(string regnr)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null && vehicles[i].RegisterNumber == regnr)
                {
                    vehicles[i] = null;
                    return true;
                }
            }
            return false;
        }

        //public T Find(string regnr)
        //{
        //    for (int i = 0; i < vehicles.Length; i++)
        //    {
        //        if (vehicles[i] != null && vehicles[i].RegisterNumber == regnr)
        //        {
        //            return vehicles[i];
        //        }
        //    }

        //    return null;
        //}

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    yield return vehicles[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

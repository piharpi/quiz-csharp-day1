using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp.Generics.Interfaces
{
    internal interface IVehicle<T>
    {
        T GetColor(T color);

        public void InfoVehicle();
    }

    class Car<T> : IVehicle<T>
    {
        public T GetColor(T color) 
        { 
            return color;
        }

        public void InfoVehicle() 
        {
            Console.WriteLine($"this is a car");
        }
    }
}

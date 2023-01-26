using Fundamental.OOP.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.OOP
{
    internal interface IVehicleFactory
    {
        public Suv CreateSUV(VehicleStruct vhs);
        public Taxi CreateTaxi(VehicleRecord vhs);

        public void DisplayVehicle<T>(List<T> listVhs);
        public int GetTotalVehicle<T>(List<T> listVhs);
        public int GetTotalVehicle(List<VehicleBase> listVhs, VehicleType vhs);
    }
}

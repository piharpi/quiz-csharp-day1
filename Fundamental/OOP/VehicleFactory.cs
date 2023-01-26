using Fundamental.OOP.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.OOP
{
    internal class VehicleFactory : IVehicleFactory
    {
        public Suv CreateSUV(VehicleStruct vhs)
        {
            return new Suv(vhs.NoPoliceReg, vhs.VehicleType, vhs.TransactionDate, vhs.Rent, vhs.DriverFee);
        }

        public Taxi CreateTaxi(VehicleRecord vhs)
        {
            return new Taxi(vhs.NoPoliceReg, vhs.VehicleType, vhs.TransactionDate, vhs.Rent, vhs.Order, vhs.OrderPerKm);
        }

        public void DisplayVehicle<T>(List<T> listVhs)
        {
            foreach (var vehicle in listVhs)
                Console.WriteLine(vehicle);
        }

        public int GetTotalVehicle<T>(List<T> listVhs)
        {
            return listVhs.Count();
        }

        public int GetTotalVehicle(List<VehicleBase> listVhs, VehicleType vhs)
        {
            return listVhs.Where(x => x.VehicleType == vhs).Count();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.OOP
{
    internal class Taxi : VehicleBase
    {
        public Taxi(string noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double rent, sbyte order, double orderPerKm) 
            : base(noPoliceReg, vehicleType, transactionDate, rent)
        {
            Order = order;
            OrderPerKm = orderPerKm;
            TotalIncome = (decimal)(Rent + (Order * OrderPerKm));
        }

        public sbyte Order { get; set; }
        public double OrderPerKm { get; set; }

        public override string ToString()
        {
            return $"NoPolicReg: {NoPoliceReg}, Type : {VehicleType}, TransactionDate : {TransactionDate}, Rent: {Rent}, Order: {Order}, OrderPerKm: {OrderPerKm}, Total : {TotalIncome}";
        }
    }
}

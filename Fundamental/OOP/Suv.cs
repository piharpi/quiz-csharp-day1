using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.OOP
{
    internal class Suv : VehicleBase
    {
        public Suv(string noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double rent, double driverFee) 
            : base(noPoliceReg, vehicleType, transactionDate, rent)
        {
            DriverFee = driverFee;
            TotalIncome = (decimal)(DriverFee + rent);
        }

        public double DriverFee { get; set; }

        public override string ToString()
        {
            return $"NoPolicReg: {NoPoliceReg}, Type : {VehicleType}, TransactionDate : {TransactionDate}, Rent: {Rent}, Driver: {DriverFee}, TotalIncome : {TotalIncome}";
        }
    }
}

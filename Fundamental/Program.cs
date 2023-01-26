using Fundamental.OOP;
using Fundamental.OOP.Structure;
using System;
using System.Collections.Generic;

namespace Fundamental // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Quiz Day 1
            //Day01.Quiz.Answer.NumSum();
            //Day01.Quiz.Answer.StringSize();
            //Day01.Quiz.Answer.ReverseString();
            //Day01.Quiz.Answer.IterationGreatest();
            //Day01.Quiz.Answer.DividerFactor();
            //Day01.Quiz.Answer.RangedPrime();
            //Day01.Quiz.Answer.ReplaceMidde();
            //Day01.Quiz.Answer.SaturdayCountdown();
            //Day01.Quiz.Answer.FindChars();
            //Day01.Quiz.Answer.FindSecondGreatest();

            //Console.WriteLine("{} \t: " + Day01.Quiz.Answer.CheckKurawal("{}"));
            //Console.WriteLine("{{}} \t: " + Day01.Quiz.Answer.CheckKurawal("{{}}"));
            //Console.WriteLine("{}} \t: " + Day01.Quiz.Answer.CheckKurawal("{}}"));
            //Console.WriteLine("{{{}}} \t: " + Day01.Quiz.Answer.CheckKurawal("{{{}}}"));

            //Day01.Quiz.Answer.Pyramid('1');
            //Day01.Quiz.Answer.Pyramid('2');
            //Day01.Quiz.Answer.Pyramid('3');
            //Day01.Quiz.Answer.Pyramid('4');

            // call interface 
            IVehicleFactory _iVehicle = new VehicleFactory();
            var suvHolder1 = new VehicleStruct
            {
                NoPoliceReg = "D 1001 UM",
                VehicleType = VehicleType.Suv,
                TransactionDate = DateTime.Now,
                DriverFee = 150_000,
                Rent = 500_000,
            };

            var suvHolder2 = new VehicleStruct
            {
                NoPoliceReg = "D 1002 UM",
                VehicleType = VehicleType.Suv,
                TransactionDate = DateTime.Now,
                DriverFee = 150_000,
                Rent = 650_000,
            };


            var taxiHolder1 = new VehicleRecord
            {
                NoPoliceReg = "V 101 TX",
                VehicleType = VehicleType.Taxi,
                TransactionDate = DateTime.Now,
                Rent = 6500,
                Order = 12,
                OrderPerKm = 6500
            };

            var taxiHolder2 = new VehicleRecord
            {
                NoPoliceReg = "V 102 TX",
                VehicleType = VehicleType.Taxi,
                TransactionDate = DateTime.Now,
                Rent = 4500,
                Order = 12,
                OrderPerKm = 6500
            };

            var suv1 = _iVehicle.CreateSUV(suvHolder1);
            var suv2 = _iVehicle.CreateSUV(suvHolder2);
            var taxi1 = _iVehicle.CreateTaxi(taxiHolder1);
            var taxi2 = _iVehicle.CreateTaxi(taxiHolder2);

            List<VehicleBase> listVehicle = new List<VehicleBase>();
            listVehicle.Add(suv1);
            listVehicle.Add(suv2);
            listVehicle.Add(taxi1);
            listVehicle.Add(taxi2);

            _iVehicle.DisplayVehicle(listVehicle);

            var totalSUV = _iVehicle.GetTotalVehicle(listVehicle, VehicleType.Suv);
            var totalTaxi = _iVehicle.GetTotalVehicle(listVehicle, VehicleType.Taxi);
            var totalJet = _iVehicle.GetTotalVehicle(listVehicle, VehicleType.Jet);
            var totalAll = _iVehicle.GetTotalVehicle(listVehicle);

            var minTotalIncome = listVehicle.Min(x => x.TotalIncome);
            var maxTotalIncome = listVehicle.Max(x => x.TotalIncome);
            Console.WriteLine($"Total Vehicle : {totalAll}");
            Console.WriteLine($"Total Suv: {totalSUV}");
            Console.WriteLine($"Total Suv: {totalTaxi}");
            Console.WriteLine($"Total Suv: {totalJet}");
            Console.WriteLine($"Min Total Income : {minTotalIncome}, Max Total Income : {maxTotalIncome}");

            var query = listVehicle.Where(x => x.TotalIncome > minTotalIncome && x.TotalIncome < maxTotalIncome).Select(vh =>
                new
                {
                    NoPolisi = vh.NoPoliceReg,
                    TotalIncome = vh.TotalIncome
                }
            );

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.Day01
{
    internal class DataTypes
    {
        public static void ShowDataTypeRange()
        {
            Console.WriteLine($"sbyte {sbyte.MinValue}  {sbyte.MaxValue}");
            Console.WriteLine($"byte {byte.MinValue}  {byte.MaxValue}");
            Console.WriteLine($"short {short.MinValue}  {short.MaxValue}");
            Console.WriteLine($"ushort {ushort.MinValue}  {ushort.MaxValue}");
            Console.WriteLine($"int {int.MinValue}  {int.MaxValue}");
            Console.WriteLine($"long {long.MinValue}  {long.MaxValue}");
            Console.WriteLine($"double {double.MinValue}  {double.MaxValue}");
            Console.WriteLine($"decimal {decimal.MinValue}  {decimal.MaxValue}");

        }

        public static void StoreCharText()
        {
            //store character
            char letter = 'A';
            char digit = '1';
            Console.WriteLine($"{letter} {digit}");
        }

        public static string StoreString()
        {
            string firstName = "kang";
            string lastName = "dian";
            //Console.WriteLine(firstName+""+lastName);
            return firstName + "" + lastName;
        }

        public static void StoreNumber()
        {
            int number = 0;
            Console.WriteLine(number);

            float f = 2.3F;
            Console.WriteLine(f);

            double d = 12.5;
            Console.WriteLine(d);
        }

        public static void ShowDouble()
        {
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} not equals 0.3");
            }
        }

        public static void ShowDecimal()
        {
            decimal a = 0.1M;
            decimal b = 0.2M;

            if (a + b == 0.3M)
            {
                Console.WriteLine($"{a + b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a + b} not equals 0.3");
            }
        }

        public static void StoreBoolean()
        {
            bool isStatus = false;
            bool isMarried = true;

        }

        public static void StoreVariable()
        {
            var salary = 10_000_000;
            var weight = 12;
            var isMarried = true;
        }

        public static void StoreConstant()
        {
            const string myName = "Bootcamp";
            const double phi = 13.1415;
        }

        public static void ShowCasting()
        {
            //cas int to decimal
            int a = 10;
            decimal d = a;

            decimal money = 10.5M;
            int e = (int)money;
        }

        public static void ShowNullableType()
        {
            Nullable<int> a;

            int? b;
            int? e = null;

            string? s;

            int? f = 45;
            if (f.HasValue)
            {
                Console.WriteLine(f.Value);
            }
        }

        public static void ShowDiffDate()
        {
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Now.AddDays(10);

            TimeSpan diff = endDate - startDate;
            int dayRemaining = diff.Days;

            Console.WriteLine($"{startDate}");
            Console.WriteLine($"{endDate}");
            Console.WriteLine($"{dayRemaining}");
            Console.WriteLine($"{startDate.DayOfWeek}");
        }
    }
}

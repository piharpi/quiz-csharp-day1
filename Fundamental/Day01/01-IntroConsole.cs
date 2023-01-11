using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.Day01
{
    internal class IntroConsole
    {
        public static void ShowConsole()
        {
            Console.WriteLine("Hello World!");

            Console.Write("Code id bootcamp");


            //02. concat
            Console.WriteLine("Code Academy " + " Bootcamp .NET");

            Console.WriteLine("Code Academy \nCool .NET");

            //04. quote
            Console.WriteLine("I love Programming \"C\"");

            //05.verbatim
            Console.WriteLine(@"Bootcamp .NET with Codeid Academy
            Lokasi Sentul City Bogor
            Indonesia
            ");

            //formating number 
            Console.WriteLine("Temperature di bogor tanggal {0} suhu {1} celcius", DateTime.Today, 20.0);
        }
    }
}

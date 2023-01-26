using AdvanceCSharp.Generics;
using AdvanceCSharp.Generics.Interfaces;

namespace AdvanceCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // call interface
            IVehicle<string> vehicle = new Car<string>();
            string color = vehicle.GetColor("Black Metallic");
            vehicle.InfoVehicle();
            Console.WriteLine($"{color}");

            // call person generic
            Person<string> personString = new();
            Console.WriteLine($"Person string : {personString.DisplayInfo("Hello")}");

            Person<int> personInt= new();
            Console.WriteLine($"Person int : {personInt.DisplayInfo(1945)}");

            Person<double> personDouble = new();
            Console.WriteLine($"Person double : {personDouble.DisplayInfo(3.00)}");

            // sample list generic
            MyList.DisplayListString();
            MyList.DisplayListInteger();
        }
    }
}
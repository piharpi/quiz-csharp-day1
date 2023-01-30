using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp.Delegate
{
    internal class SampleDelegate
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Difference(int a, int b)
        {
            return a - b;
        }

        public static bool isGreaterThan20(int number) => number > 20;
        public static void Show1(string name, int age) => Console.WriteLine($"Show1 is {name} the {age} called");
        public static void Show2(string name, int age) => Console.WriteLine($"Show2 is {name} the {age} called");
        public static void Show3(string name, int age) => Console.WriteLine($"Show3 is {name} the {age} called");
    }
    
    // delegate is reference type, untuk call gunakan new operator
    public delegate int Calculate(int a, int b);
}

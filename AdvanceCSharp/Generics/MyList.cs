using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp.Generics
{
    internal class MyList
    {
        public static void DisplayListString()
        {
            List<string> myList = new List<string>();
            myList.Add("CodeId");
            myList.Add("Bootcamp");
            myList.Add("Dotnet");

            foreach (var item in myList) 
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void DisplayListInteger()
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            foreach (var item in myList)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}

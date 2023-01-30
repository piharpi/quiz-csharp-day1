using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp.Lambda
{
    internal class SampleLambda
    {
        public static bool isEvenNotLambda(int number) { return number % 2 == 0;}

        public static bool isEvenLambda(int number) => number % 2 == 0;

        public static int Count(int[] inputArray, Predicate<int> isEven)
        {
            int count = 0;
            foreach(var num in inputArray)
                if (isEven(num)) count++;

            return count;
        }
    }
}

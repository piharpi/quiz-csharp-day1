using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.Day01
{
    internal class HandlingException
    {

        public static void ShowTryCath()
        {
			try
			{
				int a = 10;
				int b = a / 0;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				//throw;
			}
        }

        public static void ShowTryParse()
        {
            Console.WriteLine("input your age : ");
            string? input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);
                Console.WriteLine($"Your age {age}");
            }
            catch (FormatException ex) when (input.Contains("$"))
            {
                Console.WriteLine("do not use $");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

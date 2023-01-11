using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.Day01
{
    internal class ControlStatement
    {
        public static void ValidatePassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException("password is required");    
            }else if (password.Length < 8)
            {
                Console.WriteLine("Your password too short, at least 8 characaters");
            }
            else
            {
                Console.WriteLine("Your password is strong");
            }
        }

        public static void GuessOddEven()
        {
            Console.WriteLine("Enter a number : ");
            var input = Console.ReadLine();
            var number = Convert.ToInt64(input);

            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }

        public static void SwitchCase()
        {
            Console.Write("Enter a number (1-10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Smallest Number");
                    break;
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Prime Number");
                    break;
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("Even Number");
                    break;
                case 9:
                    Console.WriteLine("Odd Number");
                    break;
                case 10:
                    Console.WriteLine("Highest Number");
                    break;
                default:
                    Console.WriteLine("Out of range");
                    break;
            }
        }

        public static void GuessNumber()
        {
            Console.WriteLine("Guess magic number  :");
            Random random = new Random();
            int angkaRandom = random.Next(0, 20);

            if (angkaRandom < 5)
            {
                Console.WriteLine("< 5");
            }
            else
            {
                Console.WriteLine("> 5");
            }

        }
    }
}

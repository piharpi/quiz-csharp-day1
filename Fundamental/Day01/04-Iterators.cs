using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.Day01
{
    internal class Iterators
    {
        public static void ShowForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " : genap");
                }
                else
                {
                    Console.WriteLine(i + " : ganjil");
                }
            }
        }

        public static void ShowBox()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Console.Write((i + j) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ShowOneDiagonal()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if(row == col)
                    {
                        Console.Write((row + col) + " "); 
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void ShowWhileDo()
        {
            int i = 0;
            while (i <= 20)
            {
                Console.WriteLine("iteration : " + i);
                i++;
                if (i == 15)
                    break;

                if (i % 2 == 0)
                    continue;

            }
        }

        public static void ShowDoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"{i}");
                i++;
            } while (i <= 10);
        }

    }
}

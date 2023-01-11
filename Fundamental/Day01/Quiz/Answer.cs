namespace Fundamental.Day01.Quiz
{
    internal class Answer
    {
        public static void NumSum()
        {
            int result = 0;
            Console.Write("Enter number integer : ");
            string? input = Console.ReadLine();

            if (input == null)
                throw new ArgumentNullException("Please input numbers");

            foreach (var number in input)
                result += Convert.ToInt32(number.ToString());

            Console.WriteLine(result);
        }


        public static void StringSize()
        {
            int charCount = 0;

            Console.Write("Enter number integer : ");
            string? input = Console.ReadLine();

            if (input == null)
                Console.WriteLine(charCount);
            else
                for (;true; charCount++)
                    try
                    {
                        var isError = input[charCount];
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(charCount);
                        break;
                    }
        }

        public static void ReverseString() {
            Console.Write("Enter number integer : ");
            string? input = Console.ReadLine();

            if (input != null)
                for (int i = input.Length - 1; i >= 0; i--)
                    Console.Write(" " + input[i]);
        }

        public static void IterationGreatest()
        {
            int greatest = 0;
            int? input = 1;

            while(input != 0)
            {
                Console.Write("Enter integer [ Type 0 for exit ] : ");
                input = Convert.ToInt32(Console.ReadLine());
                greatest = input > greatest ? (int)input : greatest;
            }

            Console.WriteLine("angka terbesar : {0}", greatest);
        }

        public static void DividerFactor()
        {
            Console.Write("Enter numbers : ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                    Console.Write(i + " ");
            }
        }

        public static void RangedPrime()
        {
            int f = 0;

            Console.Write("Enter numbers : ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++) {
                for (int divider = 1; divider <= i; divider++)
                {
                    if (i % divider == 0) { f += 1; }
                    if (f > 3) { f = 0;  break; }
                }
                if (f == 2) { Console.Write(i + " "); }
                f = 0;
            }
        }

        public static void ReplaceMidde()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();
            var splited = input.Split(" ");

            for (int word = 0; word < splited.Length; word++)
            {
                for (int chr = 0; chr < splited[word].Length ; chr++)
                {
                    if (chr == 0 || chr == splited[word].Length - 1)
                        Console.Write(splited[word][chr]);
                    else
                        Console.Write('*');
                }
                Console.Write(' ');
            }
        }


        public static void SaturdayCountdown()
        {
            int more = 0;
            var saturday = DateTime.Today;

            while (true)
            {
                saturday = saturday.AddDays(1);
                more++;

                if (saturday.ToString("dddd") == "Saturday")
                    break;
            }

            Console.WriteLine("Hari Sabtu : {0}", saturday.ToString("d/MM/yyyy"));
            Console.WriteLine($"{more} hari lagi!");
        }


        public static void FindChars()
        {
            Console.Write("Enter strings : ");
            var input = Console.ReadLine();
            Console.Write("Find string : ");
            var find = Console.ReadLine();
            
            var tempFound = 0;
            var finalFound = 0;
            var idx = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == find[idx])
                    tempFound++;
                else
                    tempFound = 0;
                
                if(tempFound == find.Length)
                {
                    finalFound++;
                    tempFound = 0;
                }

                if (idx == find.Length - 1)
                    idx = 0;
                else
                {
                    idx++;
                }
            }

            Console.WriteLine("Total kata yang muncul : {0} dari text : {1}", finalFound, input);
        }

        public static void FindSecondGreatest() 
        {
            var grts = 0;
            var scnd = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i+1}. number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > grts)
                {
                    scnd = grts;
                    grts = input;
                } else if (input > scnd)
                {
                    scnd = input;
                }
            }

            Console.WriteLine("Second Greatest : {0}", scnd);
        }

        public static bool CheckKurawal(string curlies) 
        {
            int balance = 0;

            for (int i = 0; i < curlies.Length; i++)
            {
                if (curlies[i] == '{')
                    balance++;
                else
                    balance--;
            }

            return balance == 0;
        }
    
        public static void Pyramid(char kind)
        {
            if (kind == '1')
            {
                for (int row = 5; row <= 10; row++)
                {
                    for (int col = 10; col > row; col--) 
                    { 
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }

            if (kind == '2')
            {
                for (int row = 1; row <= 5; row++)
                {
                    for (int col = row; col <= row+row-1; col++) { 
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }


            if (kind == '3')
            {
                for (int row = 1; row <= 7; row++)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        if (row > 4-(col - 4))
                            continue;
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }


            if (kind == '4')
            {
                int spaces = 4;
                int number = 0;

                for (int row = 1; row <= 5; row++)
                {
                    number = row;
                    for (int col = 1; col <= 9; col++)
                    {
                        if (col <= spaces || col > 9 - spaces)
                            Console.Write("  ");
                        else 
                        {
                            Console.Write($"{number} ");
                            if (col >= 5)
                                number--;
                            else
                                number++;
                        }
                    }
                    spaces--;
                    Console.WriteLine();
                }
            }
        }
    }
}

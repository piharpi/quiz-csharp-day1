using System;

namespace Fundamental // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Quiz Day 1
            //Day01.Quiz.Answer.NumSum();
            //Day01.Quiz.Answer.StringSize();
            //Day01.Quiz.Answer.ReverseString();
            //Day01.Quiz.Answer.IterationGreatest();
            //Day01.Quiz.Answer.DividerFactor();
            //Day01.Quiz.Answer.RangedPrime();
            //Day01.Quiz.Answer.ReplaceMidde();
            //Day01.Quiz.Answer.SaturdayCountdown();
            //Day01.Quiz.Answer.FindChars();
            //Day01.Quiz.Answer.FindSecondGreatest();

            Console.WriteLine("{} \t: " + Day01.Quiz.Answer.CheckKurawal("{}"));
            Console.WriteLine("{{}} \t: " + Day01.Quiz.Answer.CheckKurawal("{{}}"));
            Console.WriteLine("{}} \t: " + Day01.Quiz.Answer.CheckKurawal("{}}"));
            Console.WriteLine("{{{}}} \t: " + Day01.Quiz.Answer.CheckKurawal("{{{}}}"));

            //Day01.Quiz.Answer.Pyramid('1');
            //Day01.Quiz.Answer.Pyramid('2');
            //Day01.Quiz.Answer.Pyramid('3');
            //Day01.Quiz.Answer.Pyramid('4');
        }


    }
}
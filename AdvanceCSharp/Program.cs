using AdvanceCSharp.Delegate;
using AdvanceCSharp.Generics;
using AdvanceCSharp.Generics.Constraint;
using AdvanceCSharp.Generics.Interfaces;
using AdvanceCSharp.Lambda;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AdvanceCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 69, 7, 8, 9, 10, 11, 12 };

            // Lambda
            int countEvenResult = SampleLambda.Count(list, SampleLambda.isEvenLambda);
            Console.WriteLine($"Jumlah bilangan genap dari list adalah : {countEvenResult}");

            int countOddResult = SampleLambda.Count(list, n => n % 2 == 1);
            Console.WriteLine($"Jumlah bilangan ganjil dari list adalah : {countOddResult}");

            // action, Func, Predicate is pre-define generic delegate types
            // Action<param1, param2, param3,...param16>
            // Func<param1, param2, param3,...param16, out return>
            // action is used to call method void
            // func is used to call non-void method
            // predicate is used to boolean return, u don't specify a return type because it is always a bool.

            // predicate implement
            Predicate<int> predicateDel = SampleDelegate.isGreaterThan20;
            Console.WriteLine($"29 is greater than 20 : {predicateDel(29)}");
            Console.WriteLine($"18 is greater than 20 : {predicateDel(18)}");

            // func implement
            Func<int, int, int> funcDel = SampleDelegate.Sum;
            Console.WriteLine($"funcDel Sum : {funcDel(12,12)}");

            funcDel = SampleDelegate.Difference;
            Console.WriteLine($"funcDel Difference : {funcDel(12, 12)}");

            // func chain delegate
            Func<int, int, int> funcDelChain = SampleDelegate.Sum;
            funcDelChain += SampleDelegate.Difference;
            Console.WriteLine($"funcDelChain Difference : {funcDelChain(12, 12)}"); // the result is last delegate

            string nama = "sentl";
            int age = 20;
            // action implementation
            Action<string, int> actionDel = SampleDelegate.Show1;

            // multi delegate / multi chain delegate
            actionDel += SampleDelegate.Show2;
            actionDel += SampleDelegate.Show3;

            actionDel(nama, age);



            // call without delegate
            Console.WriteLine($"Call without delegate: {SampleDelegate.Sum(2, 4)}");
            Console.WriteLine($"Call without delegate: {SampleDelegate.Difference(10, 7)}");

            // call instance delegate types, then assign with method Sum & Difference 
            Calculate calc = SampleDelegate.Sum;
            Console.WriteLine($"Sum delegate: {calc(4, 3)}");

            calc = SampleDelegate.Difference;
            Console.WriteLine($"Difference delegate: {calc.Invoke(9, 3)}");

            calc = (int a, int b) => a + b;
            Console.WriteLine($"Sum Lambda delegate: {calc.Invoke(10, 3)}");

            int Minus(int a, int b) => a - b;

            Console.WriteLine($"Call Lamda new delegate: {new Calculate(Minus)(100, 20)}");
            Console.WriteLine($"Call Lamda new delegate Invoke: {new Calculate(Minus).Invoke(20, 20)}");

            // generic constraint
            Employee emp1 = new("Dobleh", 10_000_000);
            Employee emp2 = new("Joko", 15_000_000);
            Employee emp3 = new("Kabor", 12_000_000);

            // declare employee repo
            EmployeeRepository<Employee> listEmployees = new EmployeeRepository<Employee>();

            listEmployees.AddEmployee(emp1);
            listEmployees.AddEmployee(emp2);        
            listEmployees.AddEmployee(emp3);

            listEmployees.DisplayEmployees();

            //EmployeeRepository<Person> listPerson = new EmployeeRepository<Person>();

            // call interface
            IVehicle<string> vehicle = new Car<string>();
            string color = vehicle.GetColor("Black Metallic");
            vehicle.InfoVehicle();
            //Console.WriteLine($"{color}");

            // call person generic
            Person<string> personString = new();
            //Console.WriteLine($"Person string : {personString.DisplayInfo("Hello")}");

            Person<int> personInt= new();
            //Console.WriteLine($"Person int : {personInt.DisplayInfo(1945)}");

            Person<double> personDouble = new();
            //Console.WriteLine($"Person double : {personDouble.DisplayInfo(3.00)}");

            // sample list generic
            MyList.DisplayListString();
            MyList.DisplayListInteger();
        }
    }
}
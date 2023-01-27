using AdvanceCSharp.Generics;
using AdvanceCSharp.Generics.Constraint;
using AdvanceCSharp.Generics.Interfaces;

namespace AdvanceCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            EmployeeRepository<Person> listPerson = new EmployeeRepository<Person>();

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
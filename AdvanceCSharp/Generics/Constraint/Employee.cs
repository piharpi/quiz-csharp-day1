using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp.Generics.Constraint
{
    internal interface IEmployee
    {
    }

    internal class Employee : IEmployee
    {
        public Employee(string? name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string? ToString()
        {
            return $"Name : {Name}, Salary: {Salary}";
        }

        public string? Name { get; set; }
        public double Salary { get; set; }
    }

    internal class EmployeeRepository<T> where T : IEmployee
    {
        readonly List<Employee> listOfEmployees = new();

        public void AddEmployee(Employee emp)
        {
            listOfEmployees.Add(emp);
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("Display Employee : ");

            foreach (var emp in listOfEmployees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    } 

    internal class Person
    {
        public Person(string? name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string? ToString()
        {
            return $"Name : {Name}, Salary: {Salary}";
        }
        public string? Name { get; set; }
        public double Salary { get; set; }
    }
}

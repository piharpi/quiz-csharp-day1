using System.Security.Cryptography;

namespace UsefulConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee(101);
            Console.WriteLine($"{emp._id}");
            Console.WriteLine($"{emp.Age}");

            emp.AddNum(10);
            emp.AddNum(11);
            emp.AddNum(12);
            emp.DisplayNums();

            decimal totalPrice, totalDiscount;
            Employee.UpdatePromo(50_000, 1000, out totalPrice, out totalDiscount);
            //Console.WriteLine($"Total Price: {totalPrice}");
            //Console.WriteLine($"Total Discount: {totalDiscount}");

            //Conceptual.IsOperator();

            //Conceptual.AsOperator();

            int x = 10; // immutable
            //Conceptual.PassingByValue(x);
            //Console.WriteLine($"Final value x : {x}");

            int y = 10; // mutable
            //Conceptual.PassingByReference(ref y);
            //Console.WriteLine($"Final value y : {y}");

            //Conceptual.ShowNullable();
        }
    }
}
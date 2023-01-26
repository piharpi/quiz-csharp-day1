using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UsefulConcept
{
    internal class Conceptual
    {
        class Shape { }
        class Circle : Shape { }
        class Rectangle : Shape { }
        public static void IsOperator()
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Console.WriteLine($"Is Circle inherit from Shape: {circle is Shape}");
            Console.WriteLine($"Is Rectangle inherit from Shape: {rectangle is Shape}");
        }

        public static void AsOperator()
        {
            Shape shape = new();
            Circle circle = new();

            Shape? convertToShape = circle as Shape;

            Console.WriteLine($"convertions 'circle as Shape' produces {convertToShape}");

            Circle? convertCircle = shape as Circle;

            if (convertCircle == null)
            {
                Console.WriteLine($"Conversion 'shape as Circle' produces null");
            }
            else
            {
                Console.WriteLine($"Conversion 'shape as Circle' produces {convertCircle}");
            }
        }

        public static void ShowNullable()
        {
            // variable reference type
            string? name = "jojon";

            if (name == null) Console.WriteLine("null value");

            // variable value type 
            int? age = null;
            if (age.HasValue)
            {
                Console.WriteLine($"age : {age}");
            }
            else
            {
                Console.WriteLine("age has no value");
            }
        }

        public static void PassingByValue(int x)
        {
            x *= 2;
            Console.WriteLine($"Body PassingByVaue, x value : {x}");
        }

        public static void PassingByReference(ref int x)
        {
            x *= 3;
            Console.WriteLine($"Body PassingByReference, y value : {x}");
        }
    }

    internal class Employee
    {
        public const decimal baseSalary = 100_000;
        public readonly int _id = 100;

        public Employee(int id)
        {
            _id = id;
        }

        // cannot set readOnly field (readonly field cannot be assigned)
        //public int SetId(int id)
        //{
        //    return _id = id;
        //}

        // readonly property
        public int Age { get; } = 20;

        public readonly List<int> myNums = new();

        public void AddNum(int num)
        {
            myNums.Add(num);
        }

        public void DisplayNums()
        {
            foreach (var item in myNums)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void UpdatePromo(double price, float promo,
            out decimal totalPrice, out decimal totalDiscount)
        {
            totalPrice = (decimal)((price * (promo/ 100)) + price);
            totalDiscount = (decimal)(price - promo);
        }
    }
}

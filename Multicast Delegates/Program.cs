using System;

namespace DelegateMultiCast
{
    public delegate void operation(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            operation op = Calculation.Add;
            op += Calculation.Subtract;
            op += Calculation.Multiply;
            op += Calculation.Divide;
            op(10, 5);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    public class Calculation
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition: " + (x + y));
        }

        public static void Subtract(int x, int y)
        {
            Console.WriteLine("Subtraction: " + (x - y));
        }

        public static void Multiply(int x, int y)
        {
            Console.WriteLine("Multiplication: " + (x * y));
        }

        public static void Divide(int x, int y)
        {
            if (y != 0)
                Console.WriteLine("Division: " + ((double)x / y));
            else
                Console.WriteLine("Cannot divide by zero.");
        }
    }
}
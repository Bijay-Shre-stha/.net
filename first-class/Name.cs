namespace Naming
{
    public class Name
    {
        public  void display()
        {
            Console.Write("Enter your name: ");
            string str = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // using string interpolation
            Console.WriteLine($"Hello {str}, you are {age} years old!");

            // using placeholder
            Console.WriteLine("Hello {0}, you are {1} years old!", str, age);
        }
    }
}
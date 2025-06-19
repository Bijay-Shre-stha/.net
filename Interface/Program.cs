using System;
namespace Interface
{
    interface A
    {
        public void sum()
        {
            Console.WriteLine("From A");

        }
    }
    interface B
    {
        public void sub()
        {
            Console.WriteLine("From B");

        }
    }

    class Demo : A, B
    {
        int a;
        int b;

        public void show(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.Write(a + b);
        }
        public void sum()
        {
            Console.Write((a + b));
        }

        public void sub()
        {
            Console.Write((a - b));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            
        }

    }


}

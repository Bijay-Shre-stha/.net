using System;
using AbstractDemoExample;
namespace AbstractDemoExample
{
    abstract class AbstractDemo
    {
        public abstract void add();
        public abstract void sub(int a, int b);
    }
    class AbstractImp : AbstractDemo
    {
        static void Main(string[] args)
        {
            AbstractImp ab = new AbstractImp();
            ab.add();

        }
        public override void add()
        {
            Console.WriteLine(10 + 20);
        }

        public override void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }

}

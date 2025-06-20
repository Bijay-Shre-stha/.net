using System;
using PartialClassDemo;
namespace PartialClassDemo
{

    public partial class Products
    {
        public void method1()
        {
            Console.WriteLine("Method from class1");
        }
    }

    public partial class Products
    {
        public void method2()
        {
            Console.WriteLine("Method from class2");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Products p = new Products();
        p.method1();
        p.method2();
    }
}
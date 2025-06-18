using System;
using BaseKeyword;
namespace BaseKeyword
{
    public class BaseKeywordClass
    {
        public BaseKeywordClass(int age)
        {
            Console.WriteLine($"Base class constructor called with age: {age}");
        }
        public string name = "BaseKeywordClass";
        public string location = "Nepal";
        public void Display()
        {
            Console.WriteLine($"Name: {name}, Location: {location}");
        }
    }
    public class DerivedKeywordClass : BaseKeywordClass
    {
        public DerivedKeywordClass(int age) : base(age)
        {
            Console.WriteLine("Derived class constructor called");
        }
        public new void Display()
        {
            base.Display(); // Call the base class method
            Console.WriteLine("Derived class display method");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        BaseKeywordClass baseObj = new BaseKeywordClass(25);
        baseObj.Display();

        DerivedKeywordClass derivedObj = new DerivedKeywordClass(30);
        derivedObj.Display();
    }
}
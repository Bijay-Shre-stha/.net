namespace OverridingDemo
{
    class BaseClass
    {
        public void display()
        {
            Console.WriteLine("BaseClass display method");
        }
    }
    class DerivedClass : BaseClass
    {
        public void display()
        {
            Console.WriteLine("DerivedClass display method");
        }
    }
}
namespace VirtualAndOverrideDemo
{
    public class BaseClass
    {
        public virtual int display(int a, int b)
        {
            return a + b;
        }
    }
    public class DerivedClass : BaseClass
    {
        public override int display(int a, int b)
        {
            return (a + b) * 2;
        }
    }
}
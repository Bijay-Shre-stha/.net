namespace DestructorDemo
{
    public class Destructor
    {
        public int n;
        public Destructor(int i)
        {
            n = i;
            Console.WriteLine("Constructor called with value: " + n);
        }
        // Destructor
        ~Destructor()
        {
            Console.WriteLine("Destructor called for value: " + n);
        }

    }



}
using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        ArrayList a = new ArrayList();
        string str = "Goodbye";
        int i = 10;
        a.Add(str);
        a.Add(i);

        foreach (object obj in a)
        {
            Console.WriteLine($"Value: {obj}");
        }
    }
}
using System;
using StructExample;
namespace StructExample
{
    struct StructSample
    {
        public int id;
        public string name;

        public StructSample(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}");
        }

    }
}

public class Program
{
    static void Main(string[] args)
    {
        StructSample sample = new StructSample(1, "John Doe");
        sample.Display();

        // Demonstrating that structs are value types
        StructSample anotherSample = sample;
        anotherSample.id = 2;
        anotherSample.name = "Jane Doe";

        Console.WriteLine("After modifying anotherSample:");
        sample.Display(); // Original struct remains unchanged
        anotherSample.Display(); // Modified struct
    }
}
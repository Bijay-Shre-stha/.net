using CreateFileHandling;
using System;
using WriteFileHandling;
using ReadFileHandling;

class Program
{
    static void Main(string[] args)
    {
        Create createFile = new Create();
        createFile.CreateFile(@"./text.txt");
        Write writeFile = new Write();
        writeFile.WriteToFile(@"./text.txt", "Hello, World!");

        Read readFile = new Read();
        readFile.ReadFromFile(@"./text.txt");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
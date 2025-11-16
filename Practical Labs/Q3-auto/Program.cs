using System;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public void display()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.Id = 1209;

        Console.WriteLine("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.WriteLine("Enter Age: ");
        s.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Student Details:");
        s.display();

    }
}
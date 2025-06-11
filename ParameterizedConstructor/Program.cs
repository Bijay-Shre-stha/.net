using ParameterizedConstructorDemo;

// Main program to demonstrate the use of a parameterized constructor


Console.WriteLine("Enter Student ID:");
string idInput = Console.ReadLine();
int id = int.Parse(idInput);
Console.WriteLine("Enter Student Name:");
string name = Console.ReadLine();
Console.WriteLine("Enter Student Age:");
string age = Console.ReadLine();



Console.WriteLine("Parameterized Constructor Demo");
Student student = new Student(id, name, age);
student.display();
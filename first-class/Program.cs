using Naming;
using AddNumber;
using NoArgumentConstructorDemo;


Name name = new Name();
name.display();

Add add = new Add();
Console.WriteLine("Enter the first number:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int b = int.Parse(Console.ReadLine());
add.PrintSum(a, b);
NoArgumentConstructor noArgumentConstructor = new NoArgumentConstructor();
noArgumentConstructor.DisplayMessage();

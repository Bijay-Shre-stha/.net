int i, j;
int[,] firstArray = new int[3, 3];
Console.WriteLine("Enter the elements of the first array (3x3):");
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        firstArray[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Your Matrix is:");
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        Console.Write(firstArray[i, j] + " ");
    }
    Console.WriteLine();
}
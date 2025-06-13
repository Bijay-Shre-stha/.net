int[][] jaggedArray = new int[5][];
jaggedArray[0] = new int[2] { 3, 5 };
jaggedArray[1] = new int[4] { 1, 2, 3, 4 };
jaggedArray[2] = new int[3] { 6, 7, 8 };
jaggedArray[3] = new int[6] { 9, 10, 11, 12, 13, 14 };
jaggedArray[4] = new int[5] { 15, 16, 17, 18, 19 };
Console.WriteLine("Your Jagged Array is:");
for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < jaggedArray.Length; i++)
{
    Console.Write("Element ({0})", i + 1);
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
    Console.ReadLine();
}

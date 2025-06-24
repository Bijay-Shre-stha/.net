using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Array arr = new int[5];
            arr.SetValue(10, 5); // This will throw an IndexOutOfRange
            Console.WriteLine("Value set successfully.");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index out of range: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
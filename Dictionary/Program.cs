class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dct = new Dictionary<int, string>();
        dct.Add(1, "one");
        dct.Add(2, "Two");

        foreach (KeyValuePair<int, string> kvp in dct)
        {
            Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
        }
    }
}
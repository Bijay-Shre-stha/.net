namespace AddNumber
{
    public class Add
    {
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public void PrintSum(int a, int b)
        {
            int sum = AddTwoNumbers(a, b);
            Console.WriteLine($"The sum of {a} and {b} is: {sum}");
        }
    }
}
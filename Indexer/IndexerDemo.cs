namespace IndexerDemo
{
    class Student
    {
        private int[] marks = new int[5];
        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < marks.Length)
                {
                    marks[index] = value;
                    if (value < 0 || value > 100)
                    {
                        Console.Write("Marks must be between 0 and 100.");
                    }
                    else
                    {
                        marks[index] = value;
                    }
                }
                else
                {
                    Console.WriteLine("Index out of range.");
                }
            }
            get
            {
                return marks[index];
            }
        }
    }
}
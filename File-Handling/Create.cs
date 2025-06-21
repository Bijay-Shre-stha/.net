namespace CreateFileHandling
{
    class Create
    {
        public void CreateFile(string filePath)
        {
            FileStream fs = null;
            if (!File.Exists(filePath))
            {
                using (fs = File.Create(filePath))
                {
                    // File created successfully
                    Console.WriteLine($"File created at: {filePath}");
                }
            }
            else
            {
                Console.WriteLine($"File already exists at: {filePath}");
            }
        }
    }
}
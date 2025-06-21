namespace ReadFileHandling
{
    using System;
    using System.IO;

    class Read
    {
        public void ReadFromFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine($"Content read from file: {filePath}");
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
        }
    }
}
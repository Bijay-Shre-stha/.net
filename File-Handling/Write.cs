namespace WriteFileHandling
{
    using System;
    using System.IO;

    class Write
    {
        public void WriteToFile(string filePath, string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(content);
                    Console.WriteLine($"Content written to file: {filePath}");
                }

                Console.WriteLine("File write operation completed Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }
    }
}
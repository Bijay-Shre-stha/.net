using ReadOnlyProperties;
using ReadWriteProperties;

ReadOnly read1 = new ReadOnly();
Console.WriteLine(read1.Name);

ReadWrite readWrite = new ReadWrite();
readWrite.Name = "New Name";
Console.WriteLine(readWrite.Name);
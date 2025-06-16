using IndexerDemo;

Student student = new Student();
// Assigning marks using the indexer
student[3] = -101;
student[0] = 85;
student[1] = 90;
Console.WriteLine(student[3]);
Console.WriteLine(student[0]);
Console.WriteLine(student[1]);

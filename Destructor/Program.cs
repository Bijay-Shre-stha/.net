using DestructorDemo;

for (int i = 0; i <= 5; i++)
{
    Destructor d = new Destructor(i);
    Console.WriteLine("Destructor object created with value: " + d.n);
    // Uncomment the next line to force garbage collection
    // GC.Collect();
    // Uncomment the next line to wait for finalization
    // GC.WaitForPendingFinalizers();
}
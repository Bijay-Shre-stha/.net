using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using var db = new AppDbContext();
        db.Database.EnsureCreated();

        while (true)
        {
            Console.WriteLine("\n1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1": AddStudent(db); break;
                case "2": ViewStudents(db); break;
                case "3": UpdateStudent(db); break;
                case "4": DeleteStudent(db); break;
                case "5": return;
            }
        }
    }

    static void AddStudent(AppDbContext db)
    {
        Console.Write("Name: ");
        var name = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        db.Students.Add(new Student { Name = name, Age = age });
        db.SaveChanges();
    }

    static void ViewStudents(AppDbContext db)
    {
        var list = db.Students.ToList();
        list.ForEach(s => Console.WriteLine($"ID: {s.Id} Name: {s.Name} Age: {s.Age}"));
    }

    static void UpdateStudent(AppDbContext db)
    {
        Console.Write("ID to update: ");
        int id = int.Parse(Console.ReadLine());
        var student = db.Students.Find(id);
        if (student == null) return;

        Console.Write("New Name: ");
        student.Name = Console.ReadLine();
        Console.Write("New Age: ");
        student.Age = int.Parse(Console.ReadLine());

        db.SaveChanges();
    }

    static void DeleteStudent(AppDbContext db)
    {
        Console.Write("ID to delete: ");
        int id = int.Parse(Console.ReadLine());
        var student = db.Students.Find(id);
        if (student == null) return;

        db.Students.Remove(student);
        db.SaveChanges();
    }
}

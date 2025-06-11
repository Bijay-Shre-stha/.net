namespace ParameterizedConstructorDemo
{
    public class Student
    {
        public int id;
        public string name;
        public string age;

        // Parameterized constructor
        public Student(int id, string name, string age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine("Student ID: " + id + " Name: " + name + " Age: " + age);
        }
    }
}
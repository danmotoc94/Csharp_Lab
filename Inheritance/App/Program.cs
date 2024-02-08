namespace App;

class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();
        Console.WriteLine("Insert a teacher");
        persons.Add(new Teacher(Console.ReadLine()));
        Console.WriteLine("Insert two students");
        persons.Add(new Student(Console.ReadLine()));
        persons.Add(new Student(Console.ReadLine()));
        
        foreach (var person in persons) {
            if (person is Student student)
                student.Study();
            else if (person is Teacher teacher)
                teacher.Explain();
        }
    }
}
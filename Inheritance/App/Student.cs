namespace App;

public class Student : Person
{
    public Student(string name) : base(name) { }

    public void Study() {
        Console.WriteLine(name + "is studying...");
    }
}
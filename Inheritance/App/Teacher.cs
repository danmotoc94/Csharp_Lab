namespace App;

public class Teacher : Person
{
    public Teacher(string name) : base(name) { }
    
    public void Explain() {
        Console.WriteLine(name + "is explaining...");
    }
}
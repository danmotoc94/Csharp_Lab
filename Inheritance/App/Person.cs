namespace App;

public class Person
{
    public string name;

    public Person(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return "Person (" + Name + ")";
    }
}
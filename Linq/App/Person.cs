namespace App;

public class Person
{
    private int personId;
    private string firstName;
    private string lastName;
    private int age;
    private int roleId;

    public Person(int personId, string firstName, string lastName, int age, int roleId) {
        this.personId = personId;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.roleId = roleId;
    }

    public int PersonId
    {
        get => personId;
        set => personId = value;
    }

    public string FirstName
    {
        get => firstName;
        set => firstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public int RoleId
    {
        get => roleId;
        set => roleId = value;
    }
}
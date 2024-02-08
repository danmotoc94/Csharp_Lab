namespace App2;

public class Employee
{
    private int employeeId;
    private string employeeFirstName;
    private string employeeLastName;
    private int age;

    public Employee(int employeeId, string employeeFirstName, string employeeLastName, int age) {
        this.employeeId = employeeId;
        this.employeeFirstName = employeeFirstName;
        this.employeeLastName = employeeLastName;
        this.age = age;
    }

    public int EmployeeId
    {
        get => employeeId;
        set => employeeId = value;
    }

    public string EmployeeFirstName
    {
        get => employeeFirstName;
        set => employeeFirstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string EmployeeLastName
    {
        get => employeeLastName;
        set => employeeLastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public override string ToString()
    {
        return "Employee (ID = " + EmployeeId + "; " + "First Name = " + EmployeeFirstName + "; " +
               "Last Name = " + EmployeeLastName + "; " + "Age = " + Age + ")";
    }
}
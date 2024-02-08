namespace App2;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee(1, "Oleg","Mark", 22);
        Employee employee2 = new Employee(2, "John", "Doe", 24);
        Employee employee3 = new Employee(3, "Alex", "Smith", 29);
        Employee employee4 = new Employee(4, "Chris", "Mike", 21);
        
        List<Employee> employees = new List<Employee>{employee1, employee2, employee3, employee4};
        
        Console.WriteLine("Initial list:");
        foreach (Employee employee in employees)
            Console.WriteLine(employee);

        employees.Remove(employee2);
        
        Console.WriteLine("\nList after removing an employee:");
        foreach (Employee employee in employees)
            Console.WriteLine(employee);
    }
}
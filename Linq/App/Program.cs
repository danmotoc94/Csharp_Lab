using System.Diagnostics;

namespace App;

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person> {
            new Person (1, "John", "Doe", 25, 1),
            new Person (2, "Jane", "Smith", 30, 2),
            new Person (3, "Alice", "Johnson", 22, 1),
            new Person (4, "Bob", "Brown", 18, 3),
            new Person (5, "Eve", "White", 60, 5)
        };
        
        List<Role> roles = new List<Role> {
            new Role (1, "Admin"),
            new Role (2, "User"),
            new Role (3, "Guest"),
            new Role (4, "Manager"),
            new Role (5, "Leader")
        };
        
        var peopleOver18 = people.Where(p => p.Age > 18);
        var allPersonNames = people.Select(p => p.FirstName);
        var peopleWithRoleId1 = people.Where(p => p.RoleId == 1);
        var firstTwoYoungest = people.OrderBy(p => p.Age).Take(2);
        var allButMostTwoYoungest = people.OrderBy(p => p.Age).Skip(2);
        var peopleWithRole = from person in people
                             join role in roles on person.RoleId equals role.RoleId
                             select new { person.FirstName, role.RoleDescription};
        var peopleOrderedByAgeDescending = people.OrderByDescending(p => p.Age);
        var peopleGroupedByRole = people.GroupBy(p => p.RoleId, (key, group) => new { RoleId = key, People = group });
        var personWithFirstName1 = people.FirstOrDefault(p => p.FirstName == "FirstName1");
        var totalPeopleWithRoleLeader = (
            from person in people
            join role in roles on person.RoleId equals role.RoleId
            where role.RoleDescription == "Leader"
            select person
        ).Count();
        var hasAnyBARole = roles.Any(r => r.RoleDescription == "BA");
        var firstPersonWithAge60 = people.FirstOrDefault(p => p.Age == 60);

        
        Console.WriteLine("People over 18:");
        foreach (var person in peopleOver18)
            Console.WriteLine(person.FirstName + ", Age: " + person.Age);

        Console.WriteLine("\nAll Person Names:");
        foreach (var name in allPersonNames)
            Console.WriteLine(name);

        Console.WriteLine("\nPeople with RoleId=1:");
        foreach (var person in peopleWithRoleId1)
            Console.WriteLine(person.FirstName + ", RoleId: " + person.RoleId);

        Console.WriteLine("\nFirst Two Youngest People:");
        foreach (var person in firstTwoYoungest)
            Console.WriteLine(person.FirstName + ", Age: " + person.Age);

        Console.WriteLine("\nAll But Most Two Youngest People:");
        foreach (var person in allButMostTwoYoungest)
            Console.WriteLine(person.FirstName + ", Age: " + person.Age);

        Console.WriteLine("\nPeople with Role:");
        foreach (var person in peopleWithRole)
            Console.WriteLine(person.FirstName + ", Role: " + person.RoleDescription);

        Console.WriteLine("\nPeople Ordered by Age Descending:");
        foreach (var person in peopleOrderedByAgeDescending)
            Console.WriteLine(person.FirstName + ", Age: " + person.Age);

        Console.WriteLine("\nPeople Grouped by Role:");
        foreach (var group in peopleGroupedByRole)
        {
            Console.WriteLine("Role Id: " + group.RoleId);
            foreach (var person in group.People)
            {
                Console.WriteLine("  " + person.FirstName + ", Age: " + person.Age);
            }
        }

        Console.WriteLine("\nPerson with First Name 'FirstName1': " + (personWithFirstName1?.FirstName ?? "Not found"));

        Console.WriteLine("\nTotal People with Role 'Leader': " + totalPeopleWithRoleLeader);

        Console.WriteLine("\nDoes any Role have 'BA'? " + hasAnyBARole);

        Console.WriteLine("\nFirst Person with Age 60: " + (firstPersonWithAge60?.FirstName ?? "Not found"));

    }
}
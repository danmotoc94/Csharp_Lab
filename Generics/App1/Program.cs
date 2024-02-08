namespace App1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insert a value for the first variable:");
        var var1 = Console.ReadLine();
        Console.WriteLine("Insert a value for the second variable:");
        var var2 = Console.ReadLine();
        
        Console.WriteLine("\nVariables before swapping them: " +
                          "\n var1 = " + var1 +
                          "\n var2 = " + var2);
        
        Swap(ref var1, ref var2);
        
        Console.WriteLine("\nVariables after swapping them: " +
                          "\n var1 = " + var1 +
                          "\n var2 = " + var2);
    }

    static void Swap<T>(ref T a, ref T b) {
        (a, b) = (b, a);
    }
}
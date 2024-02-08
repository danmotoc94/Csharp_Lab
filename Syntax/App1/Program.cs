namespace App1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert first number:");
        int nr1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert second number:");
        int nr2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("\nThe numbers before interchange:");
        Console.WriteLine("nr1: " + nr1);
        Console.WriteLine("nr2: " + nr2);
        
        (nr1, nr2) = (nr2, nr1);
        
        Console.WriteLine("\nThe numbers after interchange");
        Console.WriteLine("nr1: " + nr1);
        Console.WriteLine("nr2: " + nr2);
    }
}
namespace App;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert first number:");
        int nr1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert second number:");
        int nr2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum = " + (nr1 + nr2));
    }
}
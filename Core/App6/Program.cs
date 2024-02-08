namespace App6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce first number:");
        var nr1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce second number:");
        var nr2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(nr1 + " ^ " + nr2 + " = " + ToThePowerOf(nr1, nr2));
    }

    private static int ToThePowerOf(int nr1, int nr2) {
        if (nr2 == 0)
            return 1;
        return nr1 * ToThePowerOf(nr1, nr2 - 1);
    }
}
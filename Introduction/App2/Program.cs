namespace App2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a number:");
        int nr = Convert.ToInt32(Console.ReadLine());
        while (nr % 100 != 0) {
            Console.WriteLine("Choose a number:");
            nr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you choose is " + nr + "\n");
        }
    }
}
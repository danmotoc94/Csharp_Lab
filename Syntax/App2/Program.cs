namespace App2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert the value for a:");
        var a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insert  the value for b:");
        var b = Convert.ToDouble(Console.ReadLine());

        if (a != 0)
        {
            var x = -b / a;
            Console.WriteLine("x = -b / a = " + x + " , a != 0");
        }
        else Console.WriteLine("You cannot divide by 0!");
    }
}
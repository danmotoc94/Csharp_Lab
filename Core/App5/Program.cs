namespace App5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce number:");
        var nr = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(CheckIfNumberContains3(nr)
            ? "The number contains 3"
            : "The number doesn't contain 3");
    }

    private static bool CheckIfNumberContains3(int nr) {
        while (nr != 0) {
            if (nr % 10 == 3)
                return true;
            nr /= 10;
        }
        return false;
    }
}
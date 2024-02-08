namespace App3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Number to convert:");
        var nr = Convert.ToInt32(Console.ReadLine());

        int binary = 1;
        while (nr != 1) {
            binary = binary * 10 + nr % 2;
            nr /= 2;
        }
        
        Console.WriteLine("Binary: " + binary);
    }
}
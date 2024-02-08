namespace App2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce distance (meters):");
        var distance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduce time (hours):");
        var hours = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduce time (minutes):");
        var minutes = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduce time (seconds):");
        var seconds = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("\nYour speed in metres/sec is: " + distance / (hours * 3600 + minutes * 60 + seconds));
        Console.WriteLine("\nYour speed in km/h is: " + (distance / 1000) / (hours + minutes / 60 + seconds / 3600));
        Console.WriteLine("\nYour speed in miles/h is: " + (distance * 0.62137119) / (hours + minutes / 60 + seconds / 3600));
    }
}
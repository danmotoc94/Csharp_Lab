using System.Text.RegularExpressions;

namespace App3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert a string:");
        var input = Console.ReadLine();
        
        Console.WriteLine(DecimalDigitInformation(input));
    }
    
    static string DecimalDigitInformation(string input) {
        Match match = Regex.Match(input, @"\d");

        if (match.Success) {
            char digit = match.Value[0];
            int position = match.Index; 
            return "Digit " + digit + " at position " + position;
        }
        return "No digit found!";
    }
}
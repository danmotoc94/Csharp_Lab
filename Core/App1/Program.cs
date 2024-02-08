namespace App1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert the string:");
        string input = Console.ReadLine();
        int numberOfAlphabets = 0;
        int numberOfDigits = 0;
        int numberOfSpecialCharacters = 0;
        
        foreach (char c in input)
            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                numberOfAlphabets++;
            else if (c >= '0' && c <= '9')
                numberOfDigits++;
            else numberOfSpecialCharacters++;
        
        Console.WriteLine("\nNumber of Alphabets in the string is: " + numberOfAlphabets);
        Console.WriteLine("Number of Digits in the string is: " + numberOfDigits);
        Console.WriteLine("Number of Special characters in the string is: " + numberOfSpecialCharacters);
    }
}
namespace App2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert a string:");
        var input = Console.ReadLine();
        
        Console.WriteLine(AlmostOnlyLetters(input) ?
            "The string consists of letters only and ends with period"
            : "The string does not consist of letters only or ends with period");
    }

    private static bool AlmostOnlyLetters(string input) {
        for (int i = 0; i < input.Length; i++) {
            if (i == input.Length - 1 && input[i] != '.')
                return false;
            if (!((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' || input[i] <= 'Z')))
                return false;
        }
        return true;
    }
}
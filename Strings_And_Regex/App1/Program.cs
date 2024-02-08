namespace App1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert first string:");
        var string1 = Console.ReadLine();
        Console.WriteLine("Insert second string:");
        var string2 = Console.ReadLine();

        var mixedString = MixTwoStrings(string1, string2);
        Console.WriteLine("The result of the mixed string is: " + mixedString);
    }

    private static string MixTwoStrings(string string1, string string2) {
        int maxLength = Math.Max(string1.Length, string2.Length);
        string mixedString = "";

        for (int i = 0; i < maxLength; i++) {
            if (i < string1.Length)
                mixedString += string1[i];
            if (i < string2.Length)
                mixedString += string2[i];
        }
        return mixedString;
    }
}
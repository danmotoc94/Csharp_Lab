namespace App2;

using System;

class Program
{
    static void Main()
    {
        int[] array = {5, 4, 2, 0, 9, 1, 8};

        while (true) {
            try {
                Console.WriteLine("Insert index or 'end':");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "end") 
                    break;

                int i = Convert.ToInt32(userInput);
                Console.WriteLine("You choose " + array[i]);
            }
            catch (IndexOutOfRangeException) {
                Console.WriteLine("Invalid index!");
            }
            catch (FormatException) {
                Console.WriteLine("Invalid format!");
            }
        }
    }
}

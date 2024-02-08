namespace App1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert the number of elements:");
        var nr = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[nr];
        
        Console.WriteLine("Insert the elements:");
        for (int i = 0; i < array.Length; i++)
            array[i] = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < array.Length; i++)
            sum += array[i];
        
        Console.WriteLine("Sum of all elements stored in the array is: " + sum);
    }
}
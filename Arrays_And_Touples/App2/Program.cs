namespace App2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert the number of elements:");
        var nr = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[nr];
        int[] evenArray = new int[nr];
        int evenCount = 0;

        int[] oddArray = new int[nr];
        int oddCount = 0;
        
        Console.WriteLine("Insert the elements:");
        for (int i = 0; i < array.Length; i++) {
            array[i] = Convert.ToInt32(Console.ReadLine());
            if (array[i] % 2 == 0) {
                evenArray[evenCount] = array[i];
                evenCount++;
            } else {
                oddArray[oddCount] = array[i];
                oddCount++;
            }
        }
        
        Console.Write("\nThe Even elements are: ");
        for (int i = 0; i < evenCount; i++) 
            Console.Write(evenArray[i] + " ");
        
        Console.Write("\nThe Odd elements are : ");
        for (int i = 0; i < oddCount; i++) 
            Console.Write(oddArray[i] + " ");
    }
}
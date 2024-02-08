namespace App4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce first number:");
        var nr1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduce second number:");
        var nr2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduce operation (+, -, x, /):");
        var operation = Console.ReadLine();

        switch (operation) {
            case "+":
                Console.WriteLine("The result of " + operation + " operation is: " + (nr1 + nr2));
                break;
            case "-":
                Console.WriteLine("The result of " + operation + " operation is: " + (nr1 - nr2));
                break;
            case "x":
                Console.WriteLine("The result of " + operation + " operation is: " + (nr1 * nr2));
                break;
            case "/":
                Console.WriteLine("The result of " + operation + " operation is: " + (nr1 / nr2));
                break;
            default:
                Console.WriteLine("Unrecognized character");
                break;
        }
    }
}
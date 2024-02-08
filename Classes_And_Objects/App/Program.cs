namespace App;

class Program
{
    static void Main(string[] args)
    {
        Point point1 = CreatePoint();
        Point point2 = CreatePoint();
        Point point3 = CreatePoint();
        
        Console.WriteLine(point1.ToString());
        Console.WriteLine(point2.ToString());
        Console.WriteLine(point3.ToString());
        
        Console.WriteLine("\nThe distance between " + point1 + " and " + point2 + " = " 
                          + point1.CalculateDistance(point2));

        Triangle triangle = new Triangle(point1, point2, point3);
        Console.WriteLine(triangle.ToString());
        Console.WriteLine("\nThe perimeter of the triangle = " + triangle.CalculatePerimeter());
        Console.WriteLine("\nThe area of the triangle = " + triangle.CalculateArea());
    }

    static Point CreatePoint() {
        Console.WriteLine("\nInsert the x coordinate:");
        var x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert the y coordinate:");
        var y = Convert.ToInt32(Console.ReadLine());
        return new Point(x, y);
    }
}
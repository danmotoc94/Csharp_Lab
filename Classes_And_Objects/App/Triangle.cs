namespace App;

public class Triangle
{
    private Point xPoint;
    private Point yPoint;
    private Point zPoint;

    public Triangle(Point xPoint, Point yPoint, Point zPoint) {
        this.xPoint = xPoint;
        this.yPoint = yPoint;
        this.zPoint = zPoint;
    }

    public Point XPoint {
        get => xPoint;
        set => xPoint = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Point YPoint {
        get => yPoint;
        set => yPoint = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Point ZPoint {
        get => zPoint;
        set => zPoint = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double CalculatePerimeter() {
        var distances = ExtractDistances();
        return distances.Item1 + distances.Item2 + distances.Item3;
    }

    public double CalculateArea() {
        var distances = ExtractDistances();
        var (a, b, c) = distances;
        double semiPerimeter = (a + b + c) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
    }

    private Tuple<double, double, double> ExtractDistances() {
        double xy = xPoint.CalculateDistance(yPoint);
        double yz = yPoint.CalculateDistance(zPoint);
        double xz = xPoint.CalculateDistance(zPoint);
        return Tuple.Create(xy, yz, xz);
    }

    public override string ToString() {
        return "Triangle (" + XPoint + ";" + YPoint + ";" + ZPoint + ")";
    }
}
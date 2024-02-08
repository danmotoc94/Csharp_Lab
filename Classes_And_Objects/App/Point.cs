namespace App;

public class Point
{
    private int x;
    private int y;

    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public void CopyPoint(Point point) {
        x = point.x;
        y = point.y;
    }

    public int X {
        get => x;
        set => x = value;
    }

    public int Y {
        get => y;
        set => y = value;
    }

    public double CalculateDistance(Point point) {
        return Math.Sqrt(Math.Pow(point.x - x, 2) + Math.Pow(point.y - y, 2));
    }

    public override string ToString() {
        return "Point (" + X + ";" + Y + ")";
    }
}
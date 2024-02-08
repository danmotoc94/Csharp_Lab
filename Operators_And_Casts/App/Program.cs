namespace App;

class Program
{
    static void Main(string[] args)
    {
        Rational rational1 = new Rational(6, 2);
        Rational rational2 = new Rational(5, 7);
        
        rational1.Add(rational2);
        rational1.Subtraction(rational2);
        rational1.Multiply(rational2);
        rational1.Divide(rational2);
        rational1.LessThan(rational2);
        rational1.GreaterThan(rational2);
        rational1.GreaterOrEqualThan(rational2);
        rational1.LessOrEqualThan(rational2);
        rational1.Equal(rational2);
        rational1.NotEqual(rational2);
    }
}
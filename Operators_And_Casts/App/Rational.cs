namespace App;

public class Rational
{
    private int numerator;
    private int denominator;

    public Rational(int numerator, int denominator) {
        if (denominator == 0) 
            throw new ArgumentException("Denominator cannot be zero.");
        this.numerator = numerator;
        this.denominator = denominator;
        Simplify();
    }

    public void Add(Rational rational) {
        int resultNumerator = numerator * rational.denominator + rational.numerator * denominator;
        int resultDenominator = denominator * rational.denominator;
        Console.WriteLine("The sum is: " + resultNumerator + "/" + resultDenominator);
    }
    
    public void Subtraction(Rational rational) {
        int resultNumerator = numerator * rational.denominator - rational.numerator * denominator;
        int resultDenominator = denominator * rational.denominator;
        Console.WriteLine("The subtraction is: " + resultNumerator + "/" + resultDenominator);
    }
    
    public void Multiply(Rational rational) {
        int resultNumerator = numerator * rational.numerator;
        int resultDenominator = denominator * rational.denominator;
        Console.WriteLine("The multiplication is: " + resultNumerator + "/" + resultDenominator);
    }
    
    public void Divide(Rational rational) {
        if (rational.numerator == 0) 
            throw new ArgumentException("Denominator cannot be zero.");
        int resultNumerator = numerator * rational.denominator;
        int resultDenominator = denominator * rational.numerator;
        Console.WriteLine("The multiplication is: " + resultNumerator + "/" + resultDenominator);
    }
    
    public void LessThan(Rational rational) {
        bool isLessThan = numerator * rational.denominator < rational.numerator * denominator;
        Console.WriteLine("Is " + numerator + "/" + denominator + " < " +
                          rational.numerator + "/" + rational.denominator + " ? : " + isLessThan);
    }
    
    public void GreaterThan(Rational rational) {
        bool isGreaterThan = numerator * rational.denominator > rational.numerator * denominator;
        Console.WriteLine("Is " + numerator + "/" + denominator + " > " +
                          rational.numerator + "/" + rational.denominator + " ? : " + isGreaterThan);
    }
    
    public void GreaterOrEqualThan(Rational rational) {
        bool isGreaterOrEqualThan = numerator * rational.denominator >= rational.numerator * denominator;
        Console.WriteLine("Is " + numerator + "/" + denominator + " >= " +
                          rational.numerator + "/" + rational.denominator + " ? : " + isGreaterOrEqualThan);
    }
    
    public void LessOrEqualThan(Rational rational) {
        bool isLessOrEqualThan = numerator * rational.denominator <= rational.numerator * denominator;
        Console.WriteLine("Is " + numerator + "/" + denominator + " <= " +
                          rational.numerator + "/" + rational.denominator + " ? : " + isLessOrEqualThan);
    }
    
    public void Equal(Rational rational) {
        bool isEqual = numerator * rational.denominator == rational.numerator * denominator;
        Console.WriteLine("Is " + numerator + "/" + denominator + " = " +
                          rational.numerator + "/" + rational.denominator + " ? : " + isEqual);
    }
    
    public void NotEqual(Rational rational) {
        bool isNotEqual = numerator * rational.denominator != rational.numerator * denominator;
        Console.WriteLine("Is " + numerator + "/" + denominator + " != " +
                          rational.numerator + "/" + rational.denominator + " ? : " + isNotEqual);
    }
    
    private void Simplify() {
        int gcd = Gcd(Math.Abs(numerator), Math.Abs(denominator));
        numerator /= gcd;
        denominator /= gcd;

        if (denominator < 0) {
            numerator = -numerator;
            denominator = -denominator;
        }
    }

    private int Gcd(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
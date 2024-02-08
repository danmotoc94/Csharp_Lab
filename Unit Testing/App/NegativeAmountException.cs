namespace App;

public class NegativeAmountException : Exception
{
    public NegativeAmountException(string? message) : base(message) { }
}
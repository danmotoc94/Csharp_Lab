namespace App1;

public class TempIsZeroException : Exception
{
    public TempIsZeroException(string message) : base(message) { }
}
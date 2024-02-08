namespace App1;

class Program
{
    static void Main(string[] args)
    {
        Temperature temp1 = new Temperature(25);
        temp1.CheckTemperature();
        Temperature temp2 = new Temperature(0);
        temp2.CheckTemperature();
    }
}
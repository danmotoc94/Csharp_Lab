namespace App1;

public class Temperature
{
    private double temperature;

    public Temperature(double temperature) {
        this.temperature = temperature;
    }
    
    public void CheckTemperature() {
        if (temperature == 0)
            throw new TempIsZeroException("Temperature is zero.");
        Console.WriteLine("Temperature = " + temperature);
    }
}
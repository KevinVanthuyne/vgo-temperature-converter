
public interface ITemperatureScale
{
    string Name { get; }

    double ConvertToKevin(double temperature);
    double ConvertFromKelvin(double temperature);
}

public class KelvinTemperatureScale : ITemperatureScale
{
    public string Name => "Kelvin";

    public double ConvertFromKelvin(double temperature)
    {
        return temperature;
    }

    public double ConvertToKevin(double temperature)
    {
        return temperature;
    }
}



public interface ITemperatureScale
{
    string Name { get; }

    double ConvertToKevin(double temperature);
    double ConvertFromKelvin(double kelvin);
}

public class KelvinTemperatureScale : ITemperatureScale
{
    public string Name => "Kelvin";

    public double ConvertFromKelvin(double kelvin)
    {
        return kelvin;
    }

    public double ConvertToKevin(double kelvin)
    {
        return kelvin;
    }
}

public class CelsiusTemperatureScale : ITemperatureScale
{
    public string Name => "Celsius";

    public double ConvertFromKelvin(double kelvin)
    {
        return kelvin - 273.15;
    }

    public double ConvertToKevin(double celsius)
    {
        return celsius + 273.15;
    }
}

public class FahrenheitTemperatureScale : ITemperatureScale
{
    public string Name => "Fahrenheit";

    public double ConvertFromKelvin(double kelvin)
    {
        return kelvin * 9 / 5 - 459.67;
    }

    public double ConvertToKevin(double fahrenheit)
    {
        return (fahrenheit + 459.67) * 5 / 9;
    }
}
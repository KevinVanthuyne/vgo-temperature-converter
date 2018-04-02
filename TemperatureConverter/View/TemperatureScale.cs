
public interface ITemperatureScale
{
    string Name { get; }

    double ConvertToKevin(double temperature);
    double ConvertFromKelvin(double temperature);
}



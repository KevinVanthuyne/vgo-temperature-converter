using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int RoundTo = 3;

        public MainWindow()
        {
            InitializeComponent();
        }
        /*
        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {   
            // read from Fahrenheit textbox
            String str = FahrenheitTextBox.Text;
            var fahrenheit = double.Parse(str);
            // convert Fahrenheit
            var celsius = Math.Round((fahrenheit - 32) / 1.8, 2);
            var kelvin = Math.Round((fahrenheit + 459.67) * 5 / 9);
            // display in conversions
            CelsiusTextBox.Text = celsius.ToString();
            KelvinTextBox.Text = kelvin.ToString();
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            String str = CelsiusTextBox.Text;
            var celsius = double.Parse(str);

            var fahrenheit = Math.Round(celsius * 1.8 + 32, 2);
            var kelvin = Math.Round(celsius + 273.15, 2);

            FahrenheitTextBox.Text = fahrenheit.ToString();
            KelvinTextBox.Text = kelvin.ToString();
        }
        */
        private void ConvertKelvin(double kelvin)
        {
            var celsius = Math.Round(kelvin - 273.15, RoundTo);
            var fahrenheit = Math.Round(kelvin * 9 / 5 - 459.67, RoundTo);

            FahrenheitTextBox.Text = fahrenheit.ToString();
            CelsiusTextBox.Text = celsius.ToString();
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var kelvin = Math.Round(Slider.Value, RoundTo);
            //KelvinTextBox.Text = kelvin.ToString();

            //ConvertKelvin(kelvin);
        }
    }

    public class CelsiusConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kelvin = (double)value;
            var celsius = kelvin - 273.15;

            return celsius.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var celsius = double.Parse((string)value);
            var kelvin = celsius + 273.15;

            return kelvin;
        }
    }
}


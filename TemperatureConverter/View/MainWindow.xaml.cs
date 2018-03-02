using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {   
            // read from Fahrenheit textbox
            String str = FahrenheitTextBox.Text;
            var degrees = double.Parse(str);
            // convert Fahrenheit to Celsius
            degrees = Math.Round((degrees - 32) / 1.8, 2);
            // display in celsius textbox
            CelsiusTextBox.Text = degrees.ToString();
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            String str = CelsiusTextBox.Text;
            var degrees = double.Parse(str);
            degrees = Math.Round(degrees * 1.8 + 32, 2);
            FahrenheitTextBox.Text = degrees.ToString();
        }
    }
}


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
using System.Diagnostics;
using System.ComponentModel;

namespace View
{
   
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private double temperatureInKelvin;
        public event PropertyChangedEventHandler PropertyChanged;

        public double TemperatureInKelvin
        {
            get
            {
                return temperatureInKelvin;
            }

            set
            {
                temperatureInKelvin = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TemperatureInKelvin)));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }

    public class TemperatureConvertor : IValueConverter
    {
        public ITemperatureScale TemperatureScale { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kelvin = (double)value;
            return TemperatureScale.ConvertFromKelvin(kelvin).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var temp = (double)value;
            return TemperatureScale.ConvertToKevin(temp).ToString();
        }
    }
}


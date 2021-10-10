using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;

namespace Classwork_Homework_Binding_ColorPicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public SolidColorBrush Brush { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private int red;
        public int Red
        {
            get { return red; }
            set
            {
                red = value;
                Brush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue)));
                OnNotify("Brush");
            }
        }

        private int green;
        public int Green
        {
            get { return green; }
            set
            {
                green = value;
                Brush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue)));
                OnNotify("Brush");
            }
        }

        private int blue;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Blue
        {
            get { return blue; }
            set
            {
                blue = value;
                Brush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue)));
                OnNotify("Brush");
            }
        }

        public void OnNotify([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

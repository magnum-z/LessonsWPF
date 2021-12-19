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

namespace HelloAppDynamic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Smartphone {this.Name}; price: {this.Price}";
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button myButton = new Button();
            myButton.Width = 100;
            myButton.Height = 30;
            myButton.Content = "Press";
            myButton.HorizontalAlignment = HorizontalAlignment.Center;
            myButton.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
            layoutGrid.Children.Add(myButton);
        }
    }
}

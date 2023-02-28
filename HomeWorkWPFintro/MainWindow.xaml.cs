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

namespace HomeWorkWPFintro
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte red = (byte)random.Next(256);
            byte green = (byte)random.Next(256);
            byte blue = (byte)random.Next(256);
            SolidColorBrush color = new SolidColorBrush(Color.FromRgb(red, green, blue));
            Button button = (Button)sender;
            button.Background = color;
            MessageBox.Show($"Color Hex of Button {button.Content} : {color}");
        }

        private void Button_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = (Button)sender;
            Title = button.Content.ToString();
            if (button != null && button.Parent is Panel)
            {
                Panel parent = button.Parent as Panel;
                parent.Children.Remove(button);
            }

            e.Handled = true;
        }
    }
}

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
using System.Windows.Shapes;

namespace Windgets
{
    /// <summary>
    /// Logique d'interaction pour custom.xaml
    /// </summary>
    public partial class custom : Window
    {
        public custom()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void font10(object sender, RoutedEventArgs e)
        {
            label.FontSize = 10;
        }

        private void font12(object sender, RoutedEventArgs e)
        {
            label.FontSize = 12;
        }

        private void font30(object sender, RoutedEventArgs e)
        {
            label.FontSize = 30;
        }

        private void font48(object sender, RoutedEventArgs e)
        {
            label.FontSize = 48;
        }

        private void font55(object sender, RoutedEventArgs e)
        {
            label.FontSize = 55;
        }

        private void font72(object sender, RoutedEventArgs e)
        {
            label.FontSize = 72;
        }

        private void font90(object sender, RoutedEventArgs e)
        {
            label.FontSize = 90;
        }

        private void font112(object sender, RoutedEventArgs e)
        {
            label.FontSize = 112;
        }

        private void segoe(object sender, RoutedEventArgs e)
        {
            label.FontFamily = new FontFamily("Segoe UI");
        }

        private void arial(object sender, RoutedEventArgs e)
        {
            label.FontFamily = new FontFamily("Arial");
        }

        private void ubuntu(object sender, RoutedEventArgs e)
        {
            label.FontFamily = new FontFamily("Ubuntu Mono");
        }

        private void noto(object sender, RoutedEventArgs e)
        {
            label.FontFamily = new FontFamily("Noto Sans");
        }

        private void orb(object sender, RoutedEventArgs e)
        {
            label.FontFamily = new FontFamily("Orbitron");
        }





        private void text_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            label.Content = text.Text;
        }
    }
}

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
using System.IO;
using Microsoft.Win32;

namespace Windgets
{
    /// <summary>
    /// Logique d'interaction pour w_sticker.xaml
    /// </summary>
    public partial class w_sticker : Window
    {
        public w_sticker()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void source(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == true)
                sticker.Source = new BitmapImage(
     new Uri(openFileDialog.FileName));
        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

        private void size50(object sender, RoutedEventArgs e)
        {
            this.Width = 50;
        }

        private void size100(object sender, RoutedEventArgs e)
        {
            this.Width = 100;
        }

        private void size200(object sender, RoutedEventArgs e)
        {
            this.Width = 200;
        }

        private void size300(object sender, RoutedEventArgs e)
        {
            this.Width = 300;
        }
        private void size400(object sender, RoutedEventArgs e)
        {
            this.Width = 400;
        }

        private void size500(object sender, RoutedEventArgs e)
        {
            this.Width = 500;
        }

        private void size600(object sender, RoutedEventArgs e)
        {
            this.Width = 600;
        }

    }
}

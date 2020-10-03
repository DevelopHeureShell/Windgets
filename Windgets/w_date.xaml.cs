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
using System.Windows.Threading;

namespace Windgets
{
    /// <summary>
    /// Logique d'interaction pour w_date.xaml
    /// </summary>
    public partial class w_date : Window
    {
        public w_date()
        {
            InitializeComponent();
            DispatcherTimer messageTimer = new DispatcherTimer();
            messageTimer.Tick += new EventHandler(messageTimer_Tick);
            messageTimer.Interval = new TimeSpan(0, 0, 1);
            messageTimer.Start();
        }

        private void font10(object sender, RoutedEventArgs e)
        {
            datelabel.FontSize = 10;
        }

        private void font12(object sender, RoutedEventArgs e)
        {
            datelabel.FontSize = 12;
        }

        private void font30(object sender, RoutedEventArgs e)
        {
            datelabel.FontSize = 30;
        }

        private void font48(object sender, RoutedEventArgs e)
        {
            datelabel.FontSize = 48;
        }

        private void font55(object sender, RoutedEventArgs e)
        {
            datelabel.FontSize = 55;
        }

        private void font72(object sender, RoutedEventArgs e)
        {
            datelabel.FontSize = 72;
        }

        private void font90(object sender, RoutedEventArgs e)
        {
            datelabel.FontSize = 90;
        }

        private void font112(object sender, RoutedEventArgs e)
        {
            datelabel.FontSize = 112;
        }

        private void segoe(object sender, RoutedEventArgs e)
        {
            datelabel.FontFamily = new FontFamily("Segoe UI");
        }

        private void arial(object sender, RoutedEventArgs e)
        {
            datelabel.FontFamily = new FontFamily("Arial");
        }

        private void ubuntu(object sender, RoutedEventArgs e)
        {
            datelabel.FontFamily = new FontFamily("Ubuntu Mono");
        }

        private void noto(object sender, RoutedEventArgs e)
        {
            datelabel.FontFamily = new FontFamily("Noto Sans");
        }

        private void orb(object sender, RoutedEventArgs e)
        {
            datelabel.FontFamily = new FontFamily("Orbitron");
        }

        void messageTimer_Tick(object sender, EventArgs e)
        {

            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            datelabel.Content = date;
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

        private void blanc(object sender, RoutedEventArgs e)
        {
            datelabel.Foreground = new SolidColorBrush(Colors.White);
        }

        private void bleu(object sender, RoutedEventArgs e)
        {
            datelabel.Foreground = new SolidColorBrush(Colors.Blue);
        }

        private void rouge(object sender, RoutedEventArgs e)
        {
            datelabel.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void jaune(object sender, RoutedEventArgs e)
        {
            datelabel.Foreground = new SolidColorBrush(Colors.Yellow);
        }

        private void vert(object sender, RoutedEventArgs e)
        {
            datelabel.Foreground = new SolidColorBrush(Colors.Green);
        }
    }
}

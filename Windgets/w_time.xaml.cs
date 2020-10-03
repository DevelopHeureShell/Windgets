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
    /// Logique d'interaction pour w_time.xaml
    /// </summary>
    public partial class w_time : Window
    {
        public w_time()
        {
            InitializeComponent();
            DispatcherTimer messageTimer = new DispatcherTimer();
            messageTimer.Tick += new EventHandler(messageTimer_Tick);
            messageTimer.Interval = new TimeSpan(0, 0, 1);
            messageTimer.Start();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        void messageTimer_Tick(object sender, EventArgs e)
        {
            if (secondesmenu.IsChecked == true)
            {
                timelabel.Content = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                timelabel.Content = DateTime.Now.ToString("HH:mm");
            }
        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            timelabel.Content = DateTime.Now.ToString("HH:mm");
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            timelabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }

        private void font10(object sender, RoutedEventArgs e)
        {
            timelabel.FontSize = 10;
        }

        private void font12(object sender, RoutedEventArgs e)
        {
            timelabel.FontSize = 12;
        }

        private void font30(object sender, RoutedEventArgs e)
        {
            timelabel.FontSize = 30;
        }

        private void font48(object sender, RoutedEventArgs e)
        {
            timelabel.FontSize = 48;
        }

        private void font55(object sender, RoutedEventArgs e)
        {
            timelabel.FontSize = 55;
        }

        private void font72(object sender, RoutedEventArgs e)
        {
            timelabel.FontSize = 72;
        }

        private void font90(object sender, RoutedEventArgs e)
        {
            timelabel.FontSize = 90;
        }

        private void font112(object sender, RoutedEventArgs e)
        {
            timelabel.FontSize = 112;
        }

        private void segoe(object sender, RoutedEventArgs e)
        {
            timelabel.FontFamily = new FontFamily("Segoe UI");
        }

        private void arial(object sender, RoutedEventArgs e)
        {
            timelabel.FontFamily = new FontFamily("Arial");
        }

        private void ubuntu(object sender, RoutedEventArgs e)
        {
            timelabel.FontFamily = new FontFamily("Ubuntu Mono");
        }

        private void noto(object sender, RoutedEventArgs e)
        {
            timelabel.FontFamily = new FontFamily("Noto Sans");
        }

        private void orb(object sender, RoutedEventArgs e)
        {
            timelabel.FontFamily = new FontFamily("Orbitron");
        }
    }
}

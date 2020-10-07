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
using System.Xml.Schema;


namespace Windgets
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }



        private void PackIcon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            about about = new about();
            about.Show();
        }



        private void Time_Click_1(object sender, RoutedEventArgs e)
        {
            w_time time = new w_time();
            time.Show();
        }

        private void Date_Click_1(object sender, RoutedEventArgs e)
        {
            w_date date = new w_date();
            date.Show();
        }

        private void pic_Click_1(object sender, RoutedEventArgs e)
        {
            w_pic pic = new w_pic();
            pic.Show();
        }

        private void sti_Click_1(object sender, RoutedEventArgs e)
        {
            w_sticker sticker = new w_sticker();
            sticker.Show();
        }

        private void custom_Click_1(object sender, RoutedEventArgs e)
        {
            custom custom = new custom();
            custom.Show();
        }
    }
}

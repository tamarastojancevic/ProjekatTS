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

namespace ProjekatTS
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


        public static implicit operator MainWindow(Windows.Pocetna v)
        {
            throw new NotImplementedException();
        }
        private void Button2(object sender, RoutedEventArgs e)
        {
            Windows.Pocetna pocetna = new Windows.Pocetna();
            Window.GetWindow(this).Close();
            pocetna.ShowDialog();

        }
        private void Button1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}

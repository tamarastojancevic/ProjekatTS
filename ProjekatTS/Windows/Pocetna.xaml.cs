using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Diagnostics;

namespace ProjekatTS.Windows
{
    /// <summary>
    /// Interaction logic for Pocetna.xaml
    /// </summary>
    public partial class Pocetna : Window
    {
        private readonly object HelpNavigator;

        public Pocetna()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        internal static void ShowDialogue()
        {
            throw new NotImplementedException();
        }

      
      
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;


            switch (index)
            {
                case 0:
                    GridUserControl.Children.Clear();
                    GridUserControl.Children.Add(new Windows.Pocetna1());
                    break;
                case 1:
                    GridUserControl.Children.Clear();
                    GridUserControl.Children.Add(new Windows.Klijenti());
                    break;

                case 2:
                    GridUserControl.Children.Clear();
                    GridUserControl.Children.Add(new Windows.Zahtev());
                    break;

            

                case 3:
                    GridUserControl.Children.Clear();


                    break;
                default:
                    break;
            }
        }
        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnHelp(object sender, RoutedEventArgs e)
        {
            Process.Start("file://C:\\Users\\Tamara\\Desktop\\Projektovanje softvera prepravljeno\\ProjekatTS\\ProjekatTS\\Help\\Pomoc.chm");

        }
        private void BtnLogout(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Window.GetWindow(this).Close();
            mainWindow.ShowDialog();

        }
      

        private void Help(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Window.GetWindow(this).Close();
            mainWindow.ShowDialog();

        }

        private void Istorija(object sender, RoutedEventArgs e)
        {
            Windows.Istorija istorija = new Windows.Istorija();
            istorija.Show();

        }
        private void IstorijaZahteva(object sender, RoutedEventArgs e)
        {
            Windows.Istorija2 istorija2 = new Windows.Istorija2();
            istorija2.Show();

        }

        private void MenuItem_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}

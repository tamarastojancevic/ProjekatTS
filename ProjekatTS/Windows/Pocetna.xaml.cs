using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjekatTS.Windows
{
    /// <summary>
    /// Interaction logic for Pocetna.xaml
    /// </summary>
    public partial class Pocetna : Window
    {
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
                    GridUserControl.Children.Add(new Windows.Evidencija());
                    break;

                case 4:
                    GridUserControl.Children.Clear();


                    break;
                default:
                    break;
            }
        }

        private void MenuItem_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}

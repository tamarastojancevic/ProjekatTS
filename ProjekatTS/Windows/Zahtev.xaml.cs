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
using System.Data;
using System.Data.SQLite;

namespace ProjekatTS.Windows
{
    /// <summary>
    /// Interaction logic for Zahtev.xaml
    /// </summary>
    public partial class Zahtev : UserControl
    {
        public Zahtev()
        {
            InitializeComponent();
            RequestsDataGrid();
        }
        private void UnesiZahtev(object sender, RoutedEventArgs e)
        {
            Unesizahtev unesiZahtev = new Unesizahtev();
            Window.GetWindow(this).Show();
            unesiZahtev.ShowDialog();

        }

        private void RequestsDataGrid()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=projekat.db;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM requests where Status = 1";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    requestsDataGrid.ItemsSource = DS.Tables[0].DefaultView;
                }

                Class.Prikaz.DSglobal = DS;

            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }



        }
        private void unesiZahtev(object sender, RoutedEventArgs e)
        {

            Windows.Unesizahtev unesiZahtev = new Windows.Unesizahtev();
            unesiZahtev.Show();


        }

    }
}

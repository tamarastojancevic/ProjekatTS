using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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

namespace ProjekatTS.Windows
{
    /// <summary>
    /// Interaction logic for Evidencija.xaml
    /// </summary>
    public partial class Evidencija : UserControl
    {
        public Evidencija()
        {
            InitializeComponent();
        }

        private void DataGrid(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source= projekat.db");
        }
        private void RequestsDataGrid()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=projekat.db;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM requests";
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

        private void ClientDataGrid()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=projekat.db;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM employers";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    clientDataGrid.ItemsSource = DS.Tables[0].DefaultView;
                }

                Class.Prikaz.DSglobal = DS;

            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }



        }
    }
}

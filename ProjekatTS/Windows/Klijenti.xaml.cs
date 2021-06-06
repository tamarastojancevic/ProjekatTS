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
    /// Interaction logic for Klijenti.xaml
    /// </summary>
    public partial class Klijenti : UserControl
    {
        public Klijenti()
        {
            InitializeComponent();
        }

        private void unesiKlijenta(object sender, RoutedEventArgs e)
        {
            Windows.Unesiklijenta unesiKlijenta = new Windows.Unesiklijenta();
            unesiKlijenta.Show();



        }
     

        private void ClientDataGrid()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=projekat.db;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM employers where status = 0";
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

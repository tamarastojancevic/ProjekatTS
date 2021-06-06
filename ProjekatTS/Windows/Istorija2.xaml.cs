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
using System.Windows.Shapes;

namespace ProjekatTS.Windows
{
    /// <summary>
    /// Interaction logic for Istorija2.xaml
    /// </summary>
    public partial class Istorija2 : Window
    {
        public Istorija2()
        {
            InitializeComponent();
            RequestDataGrid();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void BtnCancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void RequestDataGrid()
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
                    requestDataGrid.ItemsSource = DS.Tables[0].DefaultView;
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

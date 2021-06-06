using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
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
    /// Interaction logic for Unesizahtev.xaml
    /// </summary>
    public partial class Unesizahtev : Window
    {
        public Unesizahtev()
        {
            InitializeComponent();
            klijenti();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void ButtonCancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void klijenti()
        {
            DataRow dr;


            SQLiteConnection con = new SQLiteConnection("Data Source= projekat.db");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("select id,ime from employers where status = 1", con);
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Debug.WriteLine(item);
                }
            }

      

            Binding binding = new Binding();
            binding.Source = dt;

            klijent.DisplayMemberPath = "Ime";
            klijent.SelectedValuePath = "ID";
            klijent.SetBinding(ComboBox.ItemsSourceProperty, binding);

            con.Close();
        }
        private void ButtonSave(object sender, System.EventArgs e)
        {
            Debug.WriteLine(klijent.SelectedValue);
            SQLiteConnection con = new SQLiteConnection("Data Source= projekat.db");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("insert into requests(Klijent, Zahtev, Cena, Datum, Status) values (@klijent, @zahtev, @cena, @datum, 1)", con);
            cmd.Parameters.AddWithValue("@klijent", klijent.SelectedValue);
            cmd.Parameters.AddWithValue("@zahtev", zahtev.Text);
            cmd.Parameters.AddWithValue("@cena", cena.Text);
            cmd.Parameters.AddWithValue("@datum", datum.Text);

            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Zahtev uspešno sačuvan");
                Close();
            }


        }
    }
}

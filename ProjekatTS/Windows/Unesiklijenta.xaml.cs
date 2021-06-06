using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for Unesiklijenta.xaml
    /// </summary>
    public partial class Unesiklijenta : Window
    {
        public Unesiklijenta()
        {
            InitializeComponent();
        }

        private const string ERROR_MESSAGE_NOTFILLED = "All fields are mandatory, please fill them!";
        private const string ERROR_MESSAGE_NOTUNIQUE = "There is already medcine with the same ID!";

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonOtkazi(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool AreAllFieldsFilled()
        {
            if (fullName != null &&
                pib != null &&
                adresa != null &&
                kontakt != null ) 
            {
                return true;
            }
            return false;
        }
       
        private void BtnSave(object sender, System.EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source= projekat.db");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("insert into employers(Ime, PIB, Adresa, Status, Kontakt) values (@fullName, @pib, @adresa, 1, @kontakt)", con);
            cmd.Parameters.AddWithValue("@fullName", fullName.Text);
            cmd.Parameters.AddWithValue("@pib", pib.Text);
            cmd.Parameters.AddWithValue("@adresa", adresa.Text);
            cmd.Parameters.AddWithValue("@kontakt", kontakt.Text);


            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Klijent uspešno sačuvan");
                Close();
            }
            else
            {
                AreAllFieldsFilled();
            }

        }
    

    }
}

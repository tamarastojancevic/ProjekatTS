using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                kontakt != null &&
                status.SelectedItem != null)
            {
                return true;
            }
            return false;
        }

     

        private void BtnSave(object sender, System.EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source= projekat.db;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fullName", fullName.Text);
            cmd.Parameters.AddWithValue("@pib", pib.Text);
            cmd.Parameters.AddWithValue("@adresa", adresa.Text);
         
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Klijent uspešno sačuvan");
            }


        }
    
    }
}

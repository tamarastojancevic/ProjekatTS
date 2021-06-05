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
    /// Interaction logic for Unesizahtev.xaml
    /// </summary>
    public partial class Unesizahtev : Window
    {
        public Unesizahtev()
        {
            InitializeComponent();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void ButtonCancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private bool AreAllFieldsFilled()
        {
            if (employers != null &&
                detalji != null &&
                cena != null &&
                rok != null &&
                status.SelectedItem != null)
            {
                return true;
            }
            return false;
        }
        private void BtnSave(object sender, System.EventArgs e)
        {
            if (AreAllFieldsFilled())
            {
                KreirajZahtev(sender);
                MainWindow window = new MainWindow();
                Close();
                window.Show();
            }
            else if (AreAllFieldsFilled())
        
            {
                ShowError_NotFilled();
            }

        }
        private void ShowError_NotFilled()
        {
            Windows.ErrorPrazno errorPrazno = new Windows.ErrorPrazno();
            errorPrazno.Show();



        }
        private void KreirajZahtev(object sender)
        {
            SqlConnection con = new SqlConnection("Data Source= projekat.db;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fullName", employers.Text);
            cmd.Parameters.AddWithValue("@pib", cena.Text);
            cmd.Parameters.AddWithValue("@adresa", rok.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Zahtev uspešno sačuvan");
            }
        }
    }
}

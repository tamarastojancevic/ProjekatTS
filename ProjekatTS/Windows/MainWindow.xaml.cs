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
using System.Data.SQLite;
using System.Data;


namespace ProjekatTS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


        private void Button1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        public static implicit operator MainWindow(Windows.Pocetna v)
        {
            throw new NotImplementedException();
        }
        private void Button2(object sender, RoutedEventArgs e)
        {


            SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source= projekat.db");
            if (sQLiteConnection.State == ConnectionState.Closed)
                sQLiteConnection.Open();

            try
            {

                String query = "select count(1) from users where username=@fullName and password=@password";
                SQLiteCommand cmd = new SQLiteCommand(query, sQLiteConnection);
                cmd.Parameters.AddWithValue("@fullName", fullName.Text);
                cmd.Parameters.AddWithValue("@password", password.Password);
                cmd.CommandType = CommandType.Text;

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    Windows.Pocetna pocetna = new Windows.Pocetna();
                    pocetna.Show();

                    var MainWindow = Window.GetWindow(this);
                    MainWindow.Close();
                }
                else
                {

                    Windows.ErrorWindow errorWindow = new Windows.ErrorWindow();
                    errorWindow.Show();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sQLiteConnection.Close();
            }
        }
      
        private bool isUserExist(string fullName, string password)
            {
            foreach (Class.User user in Class.Global.Users)
                {
                    if ((user.Username == fullName) && (user.Password == password))
                        return true;
                    return false;
                }
                return false;
            }

        }

        
      

    }


using System.Windows;
using System.Data.SqlClient;
using System;
using System.Configuration;
using Dapper;
using System.Linq;
using BCrypt.Net;
using System.Windows.Input;

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, RoutedEventArgs e)
        {
            string myPw = password.Password;
            string myHash = BCrypt.Net.BCrypt.HashPassword(myPw);
            var check = con.QueryAsync<ThisLogin>("exec SP_Retrieve_Login @Username", 
                new { Username = email.Text }).Result.SingleOrDefault();
            var result = BCrypt.Net.BCrypt.Verify(myPw, check.Password);
            if (check == null)
            {
                MessageBox.Show(BCrypt.Net.BCrypt.HashPassword(password.Password));
            }
            else
            {
                if(result == true)
                {
                    Home home = new Home(check.Role, check.Username);
                    home.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Password Incorrect");
                }
            }
        }
    }
}

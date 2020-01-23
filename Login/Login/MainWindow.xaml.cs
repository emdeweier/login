using System.Windows;
using System.Data.SqlClient;
using System;
using System.Configuration;
using Dapper;
using System.Linq;

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
            var check = con.QueryAsync<ThisLogin>("exec SP_Retrieve_Login @Username, @Password", 
                new { Username = email.Text, Password = password.Password }).Result.SingleOrDefault();
            if (check == null)
            {
                MessageBox.Show("Username or Password Incorrect");
            }
            else
            {
                Home home = new Home();
                var role = check.Role;
                home.Show();
                Close();
            }
        }
    }
}

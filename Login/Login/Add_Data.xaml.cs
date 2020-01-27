using System;
using System.Text;
using System.Windows;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
namespace Login
{
    /// <summary>
    /// Interaction logic for Add_Data.xaml
    /// </summary>
    public partial class Add_Data : Window
    {
        public string Role { get; private set; }
        public string User { get; private set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        public Add_Data(string RoleVal, string UserVal)
        {
            Role = RoleVal;
            User = UserVal;
            InitializeComponent();
            if (Role == "admin")
            {
                BTN_Add_Data.Visibility = Visibility.Visible;
                BTN_MngData.Visibility = Visibility.Visible;
            }
            else
            {
                BTN_Add_Data.Visibility = Visibility.Hidden;
                BTN_MngData.Visibility = Visibility.Hidden;
            }
        }

        private async void BTN_Submit_ClickAsync(object sender, RoutedEventArgs e)
        {

            var insert = await con.ExecuteAsync("exec SP_Insert_Employee @JobName, @DepartmentName, @MajorsName, @Name, @Address, @Email, @Phone, @BirthPlace, @BirthDate, @IdNumber, @Religion, @University, @Bachelor, @Password, @JoinDate",
                new
                {
                    JobName = jobname.Text,
                    DepartmentName = deptname.Text,
                    MajorsName = majorname.Text,
                    Name = name.Text,
                    Email = email.Text,
                    Address = address.Text,
                    Phone = phone.Text,
                    BirthPlace = birthplace.Text,
                    BirthDate = birthdate.Text,
                    IdNumber = idnumber.Text,
                    Religion = religion.Text,
                    University = university.Text,
                    Bachelor = bachelor.Text,
                    Password = idnumber.Text,
                    JoinDate = DateTime.Now.Date
                });
        }

        private void BTN_Home_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home(Role, User);
            home.Show();
            Close();
        }
    }
}

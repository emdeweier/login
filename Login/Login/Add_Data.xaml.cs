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
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;

namespace Login
{
    /// <summary>
    /// Interaction logic for Add_Data.xaml
    /// </summary>
    public partial class Add_Data : Window
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        public Add_Data()
        {
            InitializeComponent();
        }

        //private void BTN_Submit_Click(object sender, RoutedEventArgs e)
        //{
        //    var check = con.QueryAsync<ThisInsert>("exec SP_Insert_Employee @Id, @JobName, @DepartmentName, @MajorsName, @Name, @Phone, @Address, @PlaceBirth, @BirthDate, @IdentityCard, @Email, @Religion, @NPWP, @Bachelor, @University, @JoinDate",
        //        new { Id = id.Text, JobName = jobname.Text, DepartmentName = deptname.Text, MajorsName = majorname.Text, Name = name.Text, Phone = phone.Text, Address = address.Text, PlaceBirth = placebirth.Text, BirthDate = birthdate.SelectedDate,
        //        IdentityCard = idnumber.Text, Religion = religion.Text, Npwp = npwp.Text, Bachelor = bachelor.Text, University = university.Text}).Result.SingleOrDefault();
        //}
    }
}

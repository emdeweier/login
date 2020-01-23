using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace Login
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        public Home()
        {
            InitializeComponent();
        }

        private void BTN_Add_Data_Click(object sender, RoutedEventArgs e)
        {
            Add_Data add = new Add_Data();
            add.Show();
            Close();
        }

        private List<ThisViewData> GetAllEmployee()
        {
            List<ThisViewData> emp = new List<ThisViewData>();
            using (con)
            {
                emp = con.QueryAsync<ThisViewData>("exec SP_Retrieve_Data").Result.ToList();
            }
            return emp;
        }

    }
}

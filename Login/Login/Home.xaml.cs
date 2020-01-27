using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Data;
using System.Windows.Controls;

namespace Login
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public string Role { get; private set; }
        public string User { get; private set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        private object idE;

        public Home(string RoleVal, string UserVal)
        {
            Role = RoleVal;
            User = UserVal;
            InitializeComponent();
            if(Role == "admin")
            {
                BTN_Add_Data.Visibility = Visibility.Visible;
                BTN_MngBch.Visibility = Visibility.Visible;
            }
            else
            {
                BTN_Add_Data.Visibility = Visibility.Hidden;
                BTN_MngBch.Visibility = Visibility.Hidden;
            }
            Username.Text = "Welcome, "+User;
        }

        public void BTN_Add_Data_Click(object sender, RoutedEventArgs e)
        {
            Add_Data add = new Add_Data(Role, User);
            add.Show();
            Close();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var emp = con.QueryAsync<ThisViewData>("exec SP_Retrieve_Data").Result.ToList();
            var grid = sender as DataGrid;
            grid.ItemsSource = emp;
        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = DataGrid.SelectedItem;
            object idE = (DataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
        }

        private void BTN_Delete_Click(object sender, RoutedEventArgs e)
        {
            con.QueryAsync<ThisDeleteData>("exec SP_Delete_Data @Id", new { Id = idE });
        }
    }
}

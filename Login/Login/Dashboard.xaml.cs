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

namespace Login
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {
        public Dashboard(string RoleVal, string UserVal)
        {
            string Role = RoleVal;
            string User = UserVal;
            InitializeComponent();
            if (Role == "admin")
            {
                BTN_MngUser.Visibility = Visibility.Visible;
                BTN_MngBch.Visibility = Visibility.Visible;
                BTN_MngDept.Visibility = Visibility.Visible;
            }
            else
            {
                BTN_MngUser.Visibility = Visibility.Hidden;
                BTN_MngBch.Visibility = Visibility.Hidden;
                BTN_MngDept.Visibility = Visibility.Hidden;
            }
            Username.Text = "Welcome, " + User;
        }
    }
}

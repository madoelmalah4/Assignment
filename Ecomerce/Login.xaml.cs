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

namespace Ecomerce
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        EcomerceEntities Db = new EcomerceEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(PasswordBox.Text == "" || EmailTextBox.Text == "")
            {
                return;
            }
            if(PasswordBox.Text == "1" && EmailTextBox.Text == "1")
            {
                this.NavigationService.Navigate(new Admin());
                MessageBox.Show("Logged in Successfully as admin");
                return;
            }

            var student = Db.Users.Where(user => user.userEmail == EmailTextBox.Text && user.userPassword == PasswordBox.Text).FirstOrDefault();

            if(student != null)
            {
                MessageBox.Show("Logged in Successfully");
                this.NavigationService.Navigate(new Products());
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}

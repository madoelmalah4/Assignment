using System;
using System.Collections.Generic;
using System.Data.Odbc;
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
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        EcomerceEntities Db = new EcomerceEntities();
        public Signup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ConfirmPasswordBox.Text =="" || PasswordBox.Text == "" || EmailTextBox.Text == "" || NameTextBox.Text == "")
            {
                MessageBox.Show("Login Reqiured");
                return;
            }

            User user = new User();

            user.userName = NameTextBox.Text;
            user.userPassword = PasswordBox.Text;
            user.userEmail = EmailTextBox.Text;

            Db.Users.Add(user);
            Db.SaveChanges();
            MessageBox.Show("Logged in Successfully");
            this.NavigationService.Navigate(new Login());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Login());
        }
    }
}

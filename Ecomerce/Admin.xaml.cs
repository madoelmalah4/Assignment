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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        EcomerceEntities Db = new EcomerceEntities();
        public Admin()
        {
            InitializeComponent();
            Refresh();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ProductCategoryTextBox.Text = "";
            ProductIdTextBox.Text = "";
            ProductDescrobtion.Text = "";
            ProductNameTextBox.Text = "";
            ProductPriceTextBox.Text = "";
        }

        public void Refresh()
        {
            products123.ItemsSource = Db.Products.ToList();
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(ProductIdTextBox.Text == "")
            {
                return;
            }
            int id =int.Parse(ProductIdTextBox.Text);
            var recored = Db.Products.FirstOrDefault(p => p.productId == id);
            if(recored != null)
            {
            Db.Products.Remove(recored);
            MessageBox.Show("Romeved Succefully");
            Refresh();
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            if (ProductCategoryTextBox.Text == "" || ProductDescrobtion.Text == "" || ProductNameTextBox.Text == "" || ProductPriceTextBox.Text == "")
            {
                return;
            }

            if (ProductIdTextBox.Text != "")
            {
                return;
            }
            Product p = new Product();
            p.productName = ProductNameTextBox.Text;
            p.productPrice = ProductPriceTextBox.Text;  
            p.prodcutCategory = ProductCategoryTextBox.Text;
            p.productDescribtion = ProductDescrobtion.Text;
            p.productPrice = ProductPriceTextBox.Text;
            Db.Products.Add(p);
            Db.SaveChanges();
            MessageBox.Show("Added Succesfully");
            Refresh();
        }
    }
}

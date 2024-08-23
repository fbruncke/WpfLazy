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

namespace WpfLazy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IList<Lazy<Product>> products = new List<Lazy<Product>>();

        public MainWindow()
        {
            InitializeComponent();            
            //var test =  new List<Lazy<Product>>();
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(products[0].Value.Description );
        }

        private void BtnClick2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(products[1].Value.ToString());
        }

        private void BtnClickCreate_Click(object sender, RoutedEventArgs e)
        {
            products.Add( new Lazy<Product>( () => new Product(0,"Spoon", 5)) );
            products.Add(new Lazy<Product>(() => new Product(1, "PC", 500)));
            products.Add(new Lazy<Product>(() => new Product(2, "House", 500000)));
            products.Add(new Lazy<Product>(() => new Product(3, "Rocket", 5000)));

            products.Add(new Lazy<Product>(
                    () => new Product{ID=4, Description="Ipad", Price=3000 })
                );

            products.Add(new Lazy<Product>(createSpoon));//Non lambda syntax, using a named method

            Console.WriteLine("Added four products to the products collection!");
        }

        private Product createSpoon()
        {
            return new Product(0, "Spoon", 5);
        }


    }
}

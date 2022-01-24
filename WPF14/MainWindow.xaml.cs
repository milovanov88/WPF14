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
using System.Collections.ObjectModel;

namespace WPF14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product("Молоко", 80, "ProductsPic/Молоко.png", category.Еда));
            products.Add(new Product("Йогурт", 60, "ProductsPic/Йогурт.jpg", category.Еда));
            products.Add(new Product("Сливки", 120, "ProductsPic/Сливки.jpg", category.Еда));
            products.Add(new Product("Блендр", 4000, "ProductsPic/Блендр.jpg", category.Бытовая_техника));
            products.Add(new Product("СВЧ-печь", 7000, "ProductsPic/СВЧ-печь.jpg", category.Бытовая_техника));
            ProductList.ItemsSource = products;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF14
{
    public enum category
    {
        Еда,
        Бытовая_техника
    }
    public class Product
    {
        public string productName { get; set; }
        public int productCost { get; set; }
        public string productPicture { get; set; }        
        public category productCategory { get; set; }       
        public Product(string Name, int Cost, string Picture, category Category)
        {
            this.productName = Name;
            this.productCost = Cost;
            this.productPicture = Picture;
            this.productCategory = Category;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public static class ProductExtensions
    {
     
        public static double CalculateTotalValue(this List<Product> products)
        {
         
            return products.Sum(p => p.Price * p.Quantity);
        }

       
        public static List<Product> LowStock(this List<Product> products, int threshold)
        {
           
            return products.Where(p => p.Quantity < threshold).ToList();
        }
    }
}

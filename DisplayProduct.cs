using System;
using System.Collections.Generic;
using System.Text;

namespace dhurbaproject_0
{
     public class DisplayProduct
    {
        public void FormatAndDisplay(List<List<Product>> products, int storenumber)
        {
            foreach (var product in products[storenumber])
            {
                Console.WriteLine($"Name:{product.Name} Price:{product.Price} Quantity Available:{product.Quantity}");
            }
        }
    }

}

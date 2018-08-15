using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle.Impuestos
{
    public class Line
    {
        public Product _product;
        public int _quantity;
        public void AddProducts(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        internal float getLinePrize()
        {
            return _quantity * _product.Price;
        }
    }
}

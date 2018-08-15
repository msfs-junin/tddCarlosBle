using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle.Impuestos
{
    public class Stock
    {
        public Product GetProductWithCode(string v)
        {
            return new Product(v);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle.Impuestos
{
    public class Product
    {
        private string code;

        public Product(string code)
        {
            this.code = code;
            Price = 25;
        }

        public int Price { get; set; }
    }
}

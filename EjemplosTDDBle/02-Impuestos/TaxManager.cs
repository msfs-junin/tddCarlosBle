using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle.Impuestos
{
   public  class TaxManager
    {
        public float calculateTaxFor(float value)
        {
            return (float)(value * 1.21);
        }
    }
}

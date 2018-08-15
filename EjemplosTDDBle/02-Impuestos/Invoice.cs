using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle.Impuestos
{
    public class Invoice
    {
        private TaxManager taxManager;
        List<Line> _lines;

        public Invoice(TaxManager taxManager)
        {
            this.taxManager = taxManager;
            _lines = new List<Line>();
        }

        public void AddLine(Line line)
        {
            _lines.Add(line);
        }

        public float GetTotal()
        {
            float total = 0;
            foreach(Line linea in _lines)
            {
                total = total + (linea.getLinePrize());
            }
            return taxManager.calculateTaxFor(total);
        }
    }
}

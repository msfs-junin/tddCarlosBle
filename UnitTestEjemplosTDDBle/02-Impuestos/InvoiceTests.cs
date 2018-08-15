using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemplosTDDBle.Impuestos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEjemplosTDDBle
{
    [TestClass]

    public class InvoiceTests
    {
        [TestMethod]
        public void CalculateTaxes()
        {
            Stock stock = new Stock();
            Product product = stock.GetProductWithCode("x1abc3t3c");
            Line line = new Line();
            int quantity  = 10;
            line.AddProducts(product, quantity);
            Invoice invoice = new Invoice(new TaxManager());
            invoice.AddLine(line);
            float total = invoice.GetTotal();
            Assert.IsTrue(quantity * product.Price < total);
        }

}
}

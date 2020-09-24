using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ModuloX.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }
        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price = Price + CustomsFee;
        }
        public override string PriceTag()
        {
            TotalPrice();
            return base.PriceTag()+" (Customs fee: $ "+CustomsFee.ToString("F2", CultureInfo.InvariantCulture)+" )";
        }
    }
}

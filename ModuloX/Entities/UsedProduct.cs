using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ModuloX.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate{ get; set; }

        public UsedProduct()
        {

        }
        public UsedProduct(DateTime manufactureDate, string name, double price) :base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.Name + " (used) $ " + base.Price.ToString("F2",CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string priceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

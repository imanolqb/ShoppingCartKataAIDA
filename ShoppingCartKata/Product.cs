using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.Business
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double RevenuePercentage { get; set; }
        public double TaxRate { get; set; }

        public Product(string name, double price, double revenuePercentage, double taxRate)
        {
            Name = name;
            Price = price;
            RevenuePercentage = revenuePercentage;
            TaxRate = taxRate;
        }

        public double CalculateUnitPrice()
        {
            double unitPrice = Price + (Price * RevenuePercentage);
            return Math.Ceiling(unitPrice * 100) / 100;
        }

        public double CalculateFinalPrice()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var product = (Product)obj;
            return Name == product.Name && Price == product.Price;
        }
    }
}

using NUnit.Framework.Interfaces;

namespace ShoppingCartKata.Business
{
    public class ShoppingCart
    {
        public Dictionary<Product, int> Items { get; set; }

        public ShoppingCart()
        {
            Items = new Dictionary<Product, int>();
        }

        public void AddItem(Product product, int amount = 1)
        {
            if (Items.ContainsKey(product))
            {
                Items[product] += amount;
            }
            else
            {
                Items.Add(product, amount);
            }
        }

        public int TotalAmountOfOneProduct(Product product)
        {
            return Items.GetValueOrDefault(product, 0);
        }

        public int TotalAmountOfProducts()
        {
            return Items.Sum(item => this.TotalAmountOfOneProduct(item.Key));
        }

        public double TotalPrice()
        {
            return Items.Sum(item => item.Key.CalculateFinalPrice());
        }
    }
}
using NUnit.Framework.Interfaces;

namespace ShoppingCartKata.Business
{
    public class ShoppingCart
    {
        public List<Product> Items { get; set; }

        public ShoppingCart()
        {
            Items = new List<Product>();
        }

        public void AddItem(Product product)
        {
            Items.Add(product);
        }

        public int TotalAmountOfProducts()
        {
            return Items.Count;
        }

        public double TotalPrice()
        {
            throw new NotImplementedException();
            // return Items.Sum(item => item.Price);
        }
    }
}

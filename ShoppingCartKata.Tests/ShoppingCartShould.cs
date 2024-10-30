using FluentAssertions;
using NUnit.Framework;
using ShoppingCartKata.Business;

namespace ShoppingCartKata.Tests
{
    [TestFixture]
    public class ShoppingCartShould
    {
        private ShoppingCart shoppingCart;

        [SetUp]
        public void Setup()
        {
            shoppingCart = new ShoppingCart();
        }

        [TestCase("Lettuce", 1.55)]
        [TestCase("Tomato", 0.52)]
        [TestCase("Chicken", 1.34)]
        public void Return_product_when_a_product_is_passed(string name, double price)
        {
            var product = new Product(name, price, 0, 0);

            shoppingCart.AddItem(product);

            shoppingCart.Items.Should().Contain(element => element.Name == name && element.Price == price);
        }

        [Test]
        public void Return_total_amount_when_products_are_passed()
        {
            shoppingCart.AddItem(new Product("Lettuce", 1.55, 0, 0));
            shoppingCart.AddItem(new Product("Tomato", 0.52, 0, 0));
            shoppingCart.AddItem(new Product("Chicken", 1.34, 0, 0));

            var result = shoppingCart.TotalAmountOfProducts();

            result.Should().Be(3);
        }
    }
}

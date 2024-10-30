using FluentAssertions;
using NUnit.Framework;
using ShoppingCartKata.Business;

namespace ShoppingCartKata.Tests
{
    [TestFixture]
    public class ShoppingCartShould
    {
        private ShoppingCart shoppingCart;
        private Product product1;
        private Product product2;
        private Product product3;

        [SetUp]
        public void Setup()
        {
            shoppingCart = new ShoppingCart();
            product1 = new Product("Lettuce", 1.55, 0.15, 0.21);
            product2 = new Product("Tomato", 0.52, 0.15, 0.21);
            product3 = new Product("Chicken", 1.34, 0.12, 0.21);
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

        [Test]
        public void Return_unit_price_of_product_given_product()
        {
            product1.CalculateUnitPrice().Should().Be(1.79);
            product2.CalculateUnitPrice().Should().Be(0.60);
            product3.CalculateUnitPrice().Should().Be(1.51);
        }

        /*
        [Test]
        public void Return_total_amount_when_a_lettuce_is_passed()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(new Product("Lettuce", 1.55));

            var result = shoppingCart.TotalPrice();

            result.Should().Be(2.17);
        }
        */
    }
}

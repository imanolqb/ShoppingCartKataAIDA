using System.Reflection.Metadata.Ecma335;
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

            shoppingCart.AddItem(product, 1);

            shoppingCart.Items.Should().Contain(element => element.Key.Name == name && element.Key.Price == price);
        }

        [Test]
        public void Return_total_amount_of_lettuces_given_four_lettuces()
        {
            shoppingCart.AddItem(product1, 4);

            var result = shoppingCart.Items[product1];

            result.Should().Be(4);
        }

        [Test]
        public void Return_total_amount_when_products_are_passed()
        {
            shoppingCart.AddItem(product1, 3);
            shoppingCart.AddItem(product2, 5);
            shoppingCart.AddItem(product3, 9);

            var result = shoppingCart.TotalAmountOfProducts();

            result.Should().Be(17);
        }

        [Test]
        public void Return_total_price_when_lettuce_and_tomato_are_passed()
        {
            shoppingCart.AddItem(product1, 1);
            shoppingCart.AddItem(product2, 1);

            var result = shoppingCart.TotalPrice();

            result.Should().Be(2.9);
        }

        [Test]
        public void Return_total_price_when_lettuce_and_chicken_are_passed()
        {
            shoppingCart.AddItem(product1, 1);
            shoppingCart.AddItem(product3, 1);

            var result = shoppingCart.TotalPrice();

            result.Should().Be(4.0);
        }

        [Test]
        public void Return_total_price_when_lettuce_tomato_and_chicken_are_passed()
        {
            shoppingCart.AddItem(product1, 1);
            shoppingCart.AddItem(product2, 1);
            shoppingCart.AddItem(product3, 1);

            var result = shoppingCart.TotalPrice();

            result.Should().Be(4.73);
        }
    }
}

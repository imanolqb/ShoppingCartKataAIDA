using FluentAssertions;
using NUnit.Framework;
using ShoppingCartKata.Business;

namespace ShoppingCartKata.Tests
{
    [TestFixture]
    public class ProductShould
    {
        private Product product1;
        private Product product2;
        private Product product3;

        [SetUp]
        public void Setup()
        {
            product1 = new Product("Lettuce", 1.55, 0.15, 0.21);
            product2 = new Product("Tomato", 0.52, 0.15, 0.21);
            product3 = new Product("Chicken", 1.34, 0.12, 0.21);
        }

        [Test]
        public void Return_unit_price_of_product_given_product()
        {
            product1.CalculateUnitPrice().Should().Be(1.79);
            product2.CalculateUnitPrice().Should().Be(0.60);
            product3.CalculateUnitPrice().Should().Be(1.51);
        }

        [Test]
        public void Return_final_price_of_product_given_product()
        {
            product1.CalculateFinalPrice().Should().Be(2.17);
            product2.CalculateFinalPrice().Should().Be(0.73);
            product3.CalculateFinalPrice().Should().Be(1.83);
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

using ShoppingCartKata.Business;

namespace ShoppingCartKata.Printer
{
    public class ShoppingCartPrinter
    {
        public void PrintShoppingCart(ShoppingCart cart)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("| Producto     | Precio con IVA | Cantidad |");
            Console.WriteLine("| -----------  | -------------- | -------- |");

            foreach (var item in cart.Items)
            {
                var product = item.Key;
                var amount = item.Value;
                Console.WriteLine($"| {product.Name}   | {product.CalculateFinalPrice():0.00} €         | {amount}        |");
                Console.WriteLine("|------------------------------------------|");
                Console.WriteLine($"| Total productos: {cart.TotalAmountOfProducts()}                       |");
                Console.WriteLine($"| Precio total: {cart.TotalPrice():0.00} €                     |");
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}

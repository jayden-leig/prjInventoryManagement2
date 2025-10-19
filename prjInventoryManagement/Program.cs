namespace prjInventoryManagement
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Product> products = new List<Product>()
            {
                new Product { ID = 1, Name = "Laptop", Quantity = 10, Price = 12000 },
                new Product { ID = 2, Name = "Mouse", Quantity = 3, Price = 150 },
                new Product { ID = 3, Name = "Keyboard", Quantity = 6, Price = 300 },
                new Product { ID = 4, Name = "Monitor", Quantity = 2, Price = 2200 }
            };

            
            double totalValue = products.CalculateTotalValue(); 
            Console.WriteLine($"💰 Total Inventory Value: R{totalValue}");

            
            var lowStockProducts = products.LowStock(5); 
            Console.WriteLine("\n⚠️ Low Stock Products:");
            foreach (var product in lowStockProducts)
                Console.WriteLine($"- {product.Name} ({product.Quantity} left)");

            
            var nameAndPrice = from p in products
                               select new { p.Name, p.Price }; 
            Console.WriteLine("\n📋 Product Names and Prices:");
            foreach (var item in nameAndPrice)
                Console.WriteLine($"{item.Name}: R{item.Price}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

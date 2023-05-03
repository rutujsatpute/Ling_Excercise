namespace LinqDemo
{
    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void SeedData(List<Product> productList)
        {
            productList.Add(new Product { ProductId = "P001", ProductName = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000 });
            productList.Add(new Product { ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500 });
            productList.Add(new Product { ProductId = "P003", ProductName = "Tablet", Brand = "Lenovo", Quantity = 4, Price = 15000 });
            productList.Add(new Product { ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000 });
            productList.Add(new Product { ProductId = "P005", ProductName = "Earphones", Brand = "Boat", Quantity = 2, Price = 1500 });
        }
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();
            SeedData(productList);

            var products = productList.Where(p => p.Price >= 20000 && p.Price <= 40000).Select(p => p.ProductName);
            Console.WriteLine("Products with Price between 20000 to 40000:");
            Console.WriteLine();
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("-------------------------------------------------------------");

            var item = productList.Where(p => p.ProductName.Contains("a"));
            Console.WriteLine("\nProducts with ProductName containing letter 'a':");
            Console.WriteLine();
            foreach (var product in item)
            {
                Console.WriteLine($"{product.ProductId} \t {product.ProductName} \t {product.Brand} \t {product.Quantity} \t {product.Price}");
            }
            Console.WriteLine("--------------------------------------------------------------");

            var sortedproduct = productList.OrderBy(p => p.ProductName);
            Console.WriteLine("\nProducts sorted by ProductName:");
            Console.WriteLine();
            foreach (var product in sortedproduct)
            {
                Console.WriteLine($"{product.ProductId} \t {product.ProductName} \t {product.Brand} \t {product.Quantity} \t {product.Price}");
            }
            Console.WriteLine("--------------------------------------------------------------");

            var highestPrice = productList.Max(p => p.Price);
            Console.WriteLine("\nHighest Price: " + highestPrice);
            Console.WriteLine("--------------------------------------------------------------");

            var productExists = productList.Any(p => p.ProductId == "P003");
            Console.WriteLine("\nDoes Product with ProductId P003 exist? " + productExists);
        }
    }
}
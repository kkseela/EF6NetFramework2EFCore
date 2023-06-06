using Ef6.netFramework;
using System;
using System.Linq;

namespace ConsoleApp.NetFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new ProductService();
            using (var dbContext = new MyDbContext())
            {
                c.AddProduct(dbContext, "Example Product", 9.99m);
            }

            using (var dbContext = new MyDbContext())
            {
                var retrievedProduct = c.GetProducts(dbContext).FirstOrDefault();
                Console.WriteLine($"Product Name: {retrievedProduct.Name}, Price: {retrievedProduct.Price}");
            }

            Console.ReadLine();
        }
    }
}

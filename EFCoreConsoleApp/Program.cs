// See https://aka.ms/new-console-template for more information
using EFCorePorting;

using (var dbContext = new MyDbContext())
{
    var productService = new ProductService();

    // Get all products
    var products = productService.GetProducts(dbContext);
    foreach (var product in products)
    {
        Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}");
    }
}
Console.ReadLine();


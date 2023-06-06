namespace EFCorePorting
{
    public class ProductService
    {
        public void AddProduct(MyDbContext myDbContext, string name, decimal price)
        {
            using (var dbContext = myDbContext)
            {
                var product = new Product { Name = name, Price = price };
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Product> GetProducts(MyDbContext myDbContext)
        {
            using (var dbContext = myDbContext)
            {
                return dbContext.Products.ToList();
            }
        }
    }
}

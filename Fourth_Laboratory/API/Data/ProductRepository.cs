namespace API.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context) 
        {
            _context = context;
        }

        public void Create(Product product) 
        {
            _context.Add(product);
            _context.Save(SaveChanges);
        }

        public void Update(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

// a.	Return all products from database
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.Find(id);
        }

        public void Remove(Product product)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }

        [Route("ProductsGreaterThan {price}")]
        public ActionResult<List<Product>> ProductsGreaterThan(double price)
        {
            List<Product> productGreaterThanPrice = new List<Product>();

            foreach (Product product in _context.Products)
            {
                if (product.Price > price)
                {
                    productGreaterThanPrice.Add(product);
                }
            }
            return productGreaterThanPrice.ToList();
        }
    }
}
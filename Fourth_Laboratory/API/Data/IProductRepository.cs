namespace API.Data
{
    public class IProductRepository
    {
        void Create(Product product);
        IEnumerable<Product> GetAll();
        void Remove(Product product);
        void Update(Product product);
    }
}
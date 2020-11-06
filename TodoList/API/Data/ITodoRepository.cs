using API.Entities;

namespace API.Data
{
    public interface ITodoRepository
    {
        void Create(Product product);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllActive();
        IEnumerable<Product> GetAllFinished();
        void Remove(Product product);
        void Update(Product product);
        Todo GetById(int id);
    }
}
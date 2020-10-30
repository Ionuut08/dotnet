using API.Entities;
using System.Collections.Generic;
namespace API.Data
{
    public interface IProductRepository
    {
         void Create(Product product);
         IEnumerable<Product> GetAll();
         void Remove(Product product);
         void Update(Product product);
         Product GetById(int id);
    }
}
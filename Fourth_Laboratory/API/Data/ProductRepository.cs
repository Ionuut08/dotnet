using API.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
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
            _context.SaveChanges();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Update(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

// a.	Return all products from database
        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public void Remove(Product product)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }

    }
}
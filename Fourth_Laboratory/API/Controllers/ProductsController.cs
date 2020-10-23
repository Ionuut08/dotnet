using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;
        public ProductsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]

        public ActionResult<IEnumerable<Product>> Get() 
        {
            return _context.Products.ToList();
        }

        [HttpGet("{id}")]

        public ActionResult<Product> Get(int id) 
        {
            return _context.Products.Find(id);
        }

        [Route("Sum")]

        public ActionResult<double> Sum() 
        {
            double sum = 0;
            foreach (Product product in _context.Products) 
            {
                sum = sum + product.Price;
            }
            return sum;
        }

        [Route("ValidProducts")]

        public ActionResult<List<Product>> ValidProducts() 
        {
            DateTime today = DateTime.Today;
            List<Product> validProducts = new List<Product>();

            foreach (Product product in _context.Products) 
            {
                if (product.ValidTo < today) 
                {
                    validProducts.Add(product);
                }
            }
            return validProducts.ToList();
        }

        [Route("ValidSum")]

        public ActionResult<double> ValidSum() 
        {
            DateTime today = DateTime.Today;
            double sum = 0;
            foreach (Product product in _context.Products) 
            {
                if (product.ValidTo < today) 
                {
                    sum = sum + product.Price;
                }
            }
            return sum;
        }
    }
}
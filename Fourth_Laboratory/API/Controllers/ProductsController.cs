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
        private readonly IProductRepository _repository;
        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get() => _repository.GetAll().ToList();

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Product> GetById(int id) => _repository.GetById(id);

        [Route("ValidSum")]
        public ActionResult<double> ValidSum()
        {
            DateTime today = DateTime.Today;
            double sum = 0;
            foreach (Product product in _repository.GetAll())
            {
                if (product.ValidTo < today)
                {
                    sum = sum + product.Price;
                }
            }
            return sum;
        }

        [Route("Sum")]
        public ActionResult<double> Sum() 
        {
            double sum = 0;
            foreach (Product product in _repository.GetAll()) 
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

            foreach (Product product in _repository.GetAll()) 
            {
                if (product.ValidTo < today) 
                {
                    validProducts.Add(product);
                }
            }
            return validProducts.ToList();
        }

        [Route("ProductsGreaterThan{price}")]
        public ActionResult<List<Product>> ProductsGreaterThan(double price)
        {
            List<Product> productGreaterThanPrice = new List<Product>();

            foreach (Product product in _repository.GetAll())
            {
                if (product.Price > price)
                {
                    productGreaterThanPrice.Add(product);
                }
            }
            return productGreaterThanPrice.ToList();
        }

        [Route("ProductsInRange{price1}-{price2}")]
        public ActionResult<List<Product>> ProductsInRange(double price1, double price2)
        {
            List<Product> productGreaterThanPrice = new List<Product>();

            foreach (Product product in _repository.GetAll())
            {
                if (product.Price > price1 && product.Price <= price2)
                {
                    productGreaterThanPrice.Add(product);
                }
            }
            return productGreaterThanPrice.ToList();
        }


        [Route("Remove{id}")]
        public void Remove(int id)
        {
            _repository.Remove(_repository.GetById(id));
        }


        [Route("Update{id}Price{price}")]
        public void Update(int id, int price)
        {
            _repository.GetById(id).Price = price;
            _repository.SaveChanges();
        }

    }
}

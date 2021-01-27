using Products.Data.Entities;
using Products.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetWebAPIApp.Controllers
{
    public class ProductsController : ApiController
    {
        ProductDto[] products = new ProductDto[]
        {
            new ProductDto { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new ProductDto { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new ProductDto { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<ProductDto> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [Route("api/GetFromDB")]
        public IEnumerable<Product> GetProductsFromDb()
        {
            var result = new List<Product>();

            using (var context = new ProductsDatabaseContext())
            {
                var productsInDb = context.Products;

                foreach (var item in productsInDb)
                {
                    result.Add(item);
                }

            }

            return result;
        }
    }
}

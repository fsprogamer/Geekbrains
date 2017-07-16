using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPIService.Models;

namespace WebAPIService.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
        new Product { Id = 1, Name = "Чай Ахмат", Category = "Бакалея", Price = 100 },
        new Product { Id = 2, Name = "Кукла Барби", Category = "Игрушки", Price = 1000 },
        new Product { Id = 3, Name = "Дрель Интерскол", Category = "Инструменты", Price = 3000 }
        };

        public IEnumerable<Product> GetAllProducts()
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


        //[HttpPost]        
        //public IHttpActionResult Post(Product product)
        //{
        //    if (product == null)
        //    {
        //        return BadRequest("Product cannot be null");
        //    }
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    product.Id = products.Count();
        //    products[product.Id] = product;
        //    return CreatedAtRoute("GetById", new { id = product.Id }, product);
        //}

        //[HttpPut]        
        //public IHttpActionResult Put(string id, Product product)
        //{
        //    int _id = Convert.ToInt32(id);
        //    if (product == null)
        //    {
        //        return BadRequest("Product cannot be null");
        //    }
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    if (product.Id != _id)
        //    {
        //        return BadRequest("product.id does not match id parameter");
        //    }

        //    if (!products.Select ..Contains(id))
        //    {
        //        return NotFound();
        //    }

        //    _products[id] = product;
        //    return new StatusCodeResult(HttpStatusCode.NoContent, this);
        //}

        //[HttpDelete]
        //[Route("{id}")]
        //public IHttpActionResult Delete(string id)
        //{
        //    Product product = null;
        //    products.TryRemove(id, out product);
        //    return new StatusCodeResult(HttpStatusCode.NoContent, this);
        //}
    }
}


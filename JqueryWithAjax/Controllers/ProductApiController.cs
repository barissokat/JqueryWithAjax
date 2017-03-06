using JqueryWithAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JqueryWithAjax.Controllers
{
    public class ProductApiController : ApiController
    {
        [HttpGet]
        public Product Product()
        {
            var product = (from p in Data.Products where p.ID == 1 select p).FirstOrDefault();
            return product;
        }
        [HttpPost]
        public void Create(Product newProduct)
        {
            Data.Products.Add(newProduct);
        }
    }
}

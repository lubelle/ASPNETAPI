﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicWebAPI.Controllers
{
    [RoutePrefix("api/products")]

    public class ProductsController : ApiController
    {
        // GET: api/Products
        [HttpGet, Route("")]
        public IEnumerable<string> ReturnAllProducts()
        {
            return new string[] { "product1", "product2" };
        }

        // GET: api/Products/5
        [HttpGet, Route("{id:int:range(1000,3000)}")]
        public string Get(int id)
        {
            return "product";
        }

        [HttpGet, Route("{id:int:range(1000,3000)}/orders/{custid}")]
        public string Get(int id, string custid)
        {
            return "product-orders-" + custid;
        }

        // POST: api/Products
        [HttpPost, Route("")]
        public void CreateProduct([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        [HttpPut, Route("{id:int:range(1000,3000)}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        [HttpDelete, Route("{id:int:range(1000,3000)}")]
        public void Delete(int id)
        {
        }
    }
}

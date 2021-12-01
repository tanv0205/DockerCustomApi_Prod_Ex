using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerApiEx2.Models;

namespace DockerApiEx2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> prods = new List<Product>();
        public ProductsController()
        {
        }
        [HttpPost]
        public void Add(Product p)
        {
            prods.Add(p);
        }
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return prods;
        }
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return prods.Find(p => p.PId == id);
        }
        [HttpPut("{id}")]
        public IEnumerable<Product> Update(int id)
        {
            Product p= prods.Find(p => p.PId == id);
            p.PName = "brinjal";
            return prods;
        }
        [HttpDelete("{id}")]
        public void Remove(int id)
        {
            prods.RemoveAll(p => p.PId == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       // [Route("products")]

        [HttpGet]
        [Route("[action]")]
        [Route("api/Products/GetProducts")]
        public string GetProducts()
        {
            return "Lots of products";
        }

        [Route("products/{id}")]
        public string GetById(int id)
        {
            return $"Lots of products: {id}";
        }



     
    }
}

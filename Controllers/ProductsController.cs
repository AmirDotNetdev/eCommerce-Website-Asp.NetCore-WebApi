using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using tamrin2.Models;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace tamrin2.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult<List<Products>>> GetAll()
        {
            var products;
        }
    }
}
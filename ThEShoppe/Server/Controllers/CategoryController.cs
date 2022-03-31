using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using ThEShoppe.Shared;

namespace ThEShoppe.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(new List<Category>
            {
                new Category { Id = 1, Name = "Drama", Url = "drama", Icon = "camera-slr"},
                new Category { Id = 2, Name = "Comedy", Url = "comedy", Icon = "camera-slr"},
                new Category { Id = 5, Name = "Action", Url = "action", Icon = "camera-slr"},
                new Category { Id = 7, Name = "Romantic", Url = "romantic", Icon = "camera-slr"},
            });
        }
        }
}


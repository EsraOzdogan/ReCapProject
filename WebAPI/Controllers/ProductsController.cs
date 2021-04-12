using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    //attribute
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<Car> Get()
        {
            return "Merhaba";
        }
    }
}

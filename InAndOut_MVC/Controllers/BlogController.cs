using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut_MVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Article()
        {
            return Ok("Action of Blog controller was called");
        }


        [Route("Blog")]
        [Route("Blog/Index")]
        [Route("Blog/Index/{id?}")]
        public IActionResult Index(int id)
        {
            return Ok($"This is how happend");
        }
    }
}

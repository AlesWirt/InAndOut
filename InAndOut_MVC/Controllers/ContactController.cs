using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut_MVC.Controllers
{
    [Route("Admin/[controller]")]
    public class ContactController : Controller
    {
        [Route("Main")]
        public IActionResult Index()
        {
            return Ok("Action main called");
        }

        [Route("Details/{id?}")]
        public IActionResult SomeAction()
        {
            return Ok("Some action called");
        }
    }
}

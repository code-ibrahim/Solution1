using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj1.Services1.Controllers
{
    //[Route("[controller]")]
    //[Route("api/[controller]")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : Controller
    {
        public AdminController()
        {

        }

        [HttpGet]
        public JsonResult Getmethod1()
        {
            return Json("testing 1st get method of AdminController");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace reactiveui.net.Controllers
{
    public class TLDRController : Controller
    {
        [Route("/tldr")]
        public IActionResult Index()
        {
            return View();
        }

    }
}

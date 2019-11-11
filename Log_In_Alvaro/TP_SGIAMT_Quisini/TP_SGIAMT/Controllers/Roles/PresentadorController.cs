using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TP_SGIAMT.Controllers.Roles
{
    public class PresentadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PresentadorView()
        {
            return View();
        }
    }
}
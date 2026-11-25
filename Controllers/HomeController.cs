using Emergency_R_S.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Emergency_R_S.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        
    }
}

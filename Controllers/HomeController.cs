using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult index()
        {
            return View();
        }
    }
}
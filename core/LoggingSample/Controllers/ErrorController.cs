
using Microsoft.AspNetCore.Mvc;

namespace LoggingSample.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("/Error/{ErrorCode}")]
        public IActionResult Error(int ErrorCode)
        {
            return View(ErrorCode);
        }
    }
}
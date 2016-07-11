
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Diagnostics;

namespace LoggingSample.Controllers
{
    public class ErrorController : Controller
    {
        ILogger<HomeController> _logger;

        public ErrorController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("/Error/{ErrorCode}")]
        public IActionResult Error(int ErrorCode)
        {
            var moreInfo = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            _logger.LogInformation("Error occurred with Status Code : {StatusCode}, Original Path : {Original Path}",
                ErrorCode, moreInfo.OriginalPath);
            return View(ErrorCode);
        }
    }
}
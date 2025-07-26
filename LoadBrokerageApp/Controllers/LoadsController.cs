


using Microsoft.AspNetCore.Mvc;

namespace LoadBrokerageApp.Controllers
{
    public class LoadsController : Controller
    {
        private readonly ILogger<LoadsController> _logger;

        public LoadsController(ILogger<LoadsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
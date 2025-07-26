
using LoadBrokerageApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoadBrokerageApp.Controllers
{
    public class ShipperController : Controller
    {
        public IActionResult NewShipper()
        {
           return View(new Shippers());
        }
    }
}
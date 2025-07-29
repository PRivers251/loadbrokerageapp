
using LoadBrokerageApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoadBrokerageApp.Controllers
{
    public class ShipperController : Controller
    {
        public IActionResult NewShipper(StateDataController stateData)
        {
           return View(new Shippers());
        }
    }
}
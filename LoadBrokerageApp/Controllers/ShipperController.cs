//ShipperController.cs

using LoadBrokerageApp.Models;
using Microsoft.AspNetCore.Mvc;
using LoadBrokerageApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LoadBrokerageApp.Controllers
{

    public class NewShipperViewModel
    {
        public Shippers? Shipper { get; set; }
        public List<SelectListItem>? AvailableStates { get; set; }
    }

    public class ShipperController : Controller
    {
        private readonly IStateDataService _stateDataService;
        private readonly DbContext _context;

        // Constructor
        public ShipperController(IStateDataService StateDataService, DbContext context)
        {
            _stateDataService = StateDataService;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> NewShipper()
        {
            var statesList = await _stateDataService.GetStates();

            var availableStates = statesList.Select(s => new SelectListItem
            {
                Value = s.abbreviation,
                Text = s.abbreviation
            }).ToList();

            var viewModel = new NewShipperViewModel
            {
                Shipper = new Shippers(),
                AvailableStates = availableStates
            };

            return View(viewModel);
        }
    }
}



using System.Reflection.Metadata.Ecma335;
using AspNetCoreGeneratedDocument;
using LoadBrokerageApp.Models;
using Microsoft.AspNetCore.Mvc;
using LoadBrokerageApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoadBrokerageApp.Data;
using System.Web;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using LoadBrokerageApp.Interfaces;

namespace LoadBrokerageApp.Controllers
{

    public class NewCarrierViewModel : IViewModel<Carriers>
    {
        public Carriers? Entity { get; set; }
        public List<SelectListItem>? AvailableStates { get; set; }
    }

    public class CarrierController : Controller
    {
        private LoadBrokerageDBContext _context;
        private IStateDataService _stateDataService;

        public CarrierController(IStateDataService stateDataService, LoadBrokerageDBContext context)
        {
            _context = context;
            _stateDataService = stateDataService;
        }

        [HttpGet]
        public async Task<IActionResult> NewCarriers()
        {

            var statesList = await _stateDataService.GetStates();

            var availableStates = statesList.Select(s => new SelectListItem
            {
                Value = s.abbreviation,
                Text = s.abbreviation
            }).ToList();

            var viewModel = new NewCarrierViewModel
            {
                Entity = new Carriers(),
                AvailableStates = availableStates
            };

            return View();
        }
    }
}
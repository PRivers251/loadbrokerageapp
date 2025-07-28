using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using LoadBrokerageApp.Models;


namespace LoadBrokerageApp.Controllers
{
    public class StateDataController : Controller
    {

        private readonly IWebHostEnvironment _webHostEnvironment;

        public StateDataController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult List()
        {
            List<States> states = new List<States>();

            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "data", "states_titlecase.json");

            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    string jsonContent = System.IO.File.ReadAllText(filePath);

                    states = JsonSerializer.Deserialize<List<States>>(jsonContent);
                }

                catch (JsonException ex)
                {
                    Console.Write($"Error deserializing states_titlecase.json: {ex.Message}")
                }
            }
        }
    }
} 
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using LoadBrokerageApp.Models;
using System.Threading.Tasks;


namespace LoadBrokerageApp.Controllers
{
    public class StateDataController : Controller
    {

        private readonly IWebHostEnvironment _webHostEnvironment;

        public StateDataController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> List()
        {
            List<States> states;

            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "data", "states_titlecase.json");

            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    string jsonContent = System.IO.File.ReadAllText(filePath);

                    states = JsonSerializer.Deserialize<List<States>>(jsonContent) ?? new List<States>();

                    Console.Write(states);
                    return Json(states);
                }

                catch (JsonException ex)
                {
                    return NotFound(new { message = $"File not found: {ex.Message}" });
                }

                catch (IOException ex)
                {
                    return BadRequest(new {message = $"Cannot read data: {ex.Message}"});
                }
            }
            else
            {
                return StatusCode(500, new {error = "Server error."});
            }

            }
        }
    }
//StateDataService.cs

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using LoadBrokerageApp.Models;
using System.Threading.Tasks;
using System.ComponentModel;


namespace LoadBrokerageApp.Services
{
    public interface IStateDataService
    {
        Task<List<States>> GetStates();
    }

    public class StateDataService : IStateDataService
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<StateDataService> _logger;

        // **Constructor**
        public StateDataService(IWebHostEnvironment webHostEnvironment, ILogger<StateDataService> logger)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }

        public async Task<List<States>> GetStates()
        {
            List<States> states;

            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "data", "states_titlecase.json");
            _logger.LogDebug($"filePath: {filePath}");
            if (File.Exists(filePath))
            {
                try
                {
                    string jsonContent = await File.ReadAllTextAsync(filePath);
                    _logger.LogDebug($"From StateDataService: jsonContent: {jsonContent}");

                    states = JsonSerializer.Deserialize<List<States>>(jsonContent) ?? [];
                   _logger.LogDebug($"\n\n From StateDataService: {states}");
                    return states;
                }

                catch (JsonException ex)
                {
                    throw new JsonException($"Cannot read file at ${filePath}: ${ex.Message}");
                }

            }
            else
            {
                throw new FileNotFoundException($"File not found at: ${filePath}");
            }

        }
    }
    }
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Epidemic.Models;
using Epidemic.Models.PlayerCards;
using Microsoft.AspNetCore.Mvc;

namespace Epidemic.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly IPlayerCardDeck _playerCardDeck;
        public SampleDataController(IPlayerCardDeck playerCardDeck)
        {
            _playerCardDeck = playerCardDeck;
        }
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IActionResult WeatherForecasts()
        {
            var players = new List<Player>();
            _playerCardDeck.Draw();
            foreach (var player in players)
            {
                player.AddCities();
            }
            return Ok();
            
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}

using App.Host.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App.Host.Web.Controllers
{
    /// <summary>
    /// REST API Controller for Weather Forecasting.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private string[] Summaries;

        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fooservice"></param>
        /// <param name="logger"></param>
        public WeatherForecastController(
            IFooService fooservice, 
            ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            var r = fooservice.SayHello("Tom");

            Summaries = new[]
                {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", r
                };
        }

        /// <summary>
        /// REST API GET Verb handler
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
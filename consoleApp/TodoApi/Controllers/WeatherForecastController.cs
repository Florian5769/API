using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController] ////L'attribut [ApiController] est utilisé pour indiquer que la classe est un contrôleur d'API
[Route("[controller]")] //[Route("[controller]")] spécifie l'URL de base pour les routes associées à ce contrôleur
//Ce sont les directives d'utilisation (using) nécessaires pour inclure les espaces de noms utilisés dans le code.
public class WeatherForecastController : ControllerBase  //La classe WeatherForecastController hérite de la classe ControllerBase, qui fournit des fonctionnalités communes aux contrôleurs d'API.
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")] //[HttpGet(Name = "GetWeatherForecast")] est utilisé pour donner un nom spécifique à cette action de contrôleur.
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

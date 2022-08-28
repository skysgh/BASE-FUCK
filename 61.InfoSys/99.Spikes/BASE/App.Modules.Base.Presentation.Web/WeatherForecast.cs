namespace App.Host.Web
{
    /// <summary>
    /// DTO for WeatherServiceController
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Date of Weather Reading
        /// </summary>
        public DateTime Date { get; set; }


        /// <summary>
        /// Temperature in C
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Temperature in F
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Text based summary of temperature
        /// </summary>
        public string? Summary { get; set; }
    }
}
using System;
namespace Clase8.Models
{
    public abstract class WeatherForecastBase
    {
        public virtual DateTime Date { get; set; }

        public int TemperatureC { get; set; }
    }
}
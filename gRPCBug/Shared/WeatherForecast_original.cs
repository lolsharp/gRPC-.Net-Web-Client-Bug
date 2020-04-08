using System;
using System.Collections.Generic;
using System.Text;

namespace gRPCBug.Shared
{
    public class WeatherForecast_original
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}

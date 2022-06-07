using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStenden
{
    class weatherInfo
    {
        public class weather
        {
            public string Main { get; set; }
            public string Description { get; set; }
        }
        public class main
        {
            public double Temp { get; set; }
            public double Humidity { get; set; }
        }
        public class wind
        {
            public double Speed { get; set; }
            public int Deg { get; set; }
        }
        public class sys
        {
            public string Country { get; set; }
        }
        public class root
        {
            public List<weather> weatherList { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public double dt;
            public sys sys { get; set; }
            public string Name { get; set; }
        }        
        public class multiple
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class WindChill
    {
        public static double Temperature()
        {
            Console.WriteLine("Enter value for temperature in Fahrenhite");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for WindSpeed in miles/hr");
            double windspeed = Convert.ToDouble(Console.ReadLine());

            if (temperature < 50 && windspeed < 120 && windspeed > 3)
            {

                double windchill = 35.75 + 0.6215 + (0.4275 * temperature - 35.75) * Math.Pow(windspeed, 2);
                Console.WriteLine("WindChill="+windchill);
                

            }
            else
            {
                Console.WriteLine("Cannot comply with temperature or windspeed values");
                return 0;

            }
            return 0;
        }
    }
}
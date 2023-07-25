using System;
using System.Net.Http;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {

        static void Main(string[] args)
        {
            //How to do call the static Method? Its the classname where the Method is created and the methods name

            //For the first exercise I would like to call the Convo Method which is calling the othr 2 methods
            //therefore first i call the call and thenb the Methods
            Console.WriteLine("FIRST EXERCIZE");
            Console.WriteLine("This is the result from the first exercise with the quotes from Kanye and Ron");
            RonVSKanyeAPI.Convo();

            Console.WriteLine("==============================================================================");
            Console.WriteLine("");
            //For the second exercise I would like to call the weatherforCity
            Console.WriteLine("SECOND EXERCIZE");
            Console.WriteLine("This is the result from the second exercise with the weather Ron");
            OpenWeatherMapAPI.WeatherforCity();
        }
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void KanyeQuote()
        {
            //Create new HTTPClient
            HttpClient client = new HttpClient();

            //Kanye URL
            string yeURL = "https://api.kanye.rest";

            //get response
            string yeResponse = client.GetStringAsync(yeURL).Result;

            //Parse the Object
            JObject yeObject = JObject.Parse(yeResponse);

            //write the quote
            Console.WriteLine($"Kanye: {yeObject["quote"]}");

        }
        public static void RonQuote()
        {
            //Create new HTTPClient
            HttpClient client1 = new HttpClient();

            //Ron URL
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            //get response
            var ronResponse = client1.GetStringAsync(ronURL).Result;

            //Parse the Object
            var ronObject = JArray.Parse(ronResponse);

            //write the quote
            //Console.WriteLine(ronObject[0]);
            //Console.WriteLine($"Ron: {ronObject["quote"]}");
            
            Console.WriteLine($"Ron: {ronObject[0]}");
            Console.WriteLine();


        }
        public static void Convo()
        {
            for (int i = 1; i <= 5; i++)
            //for(int i = 0; i <= 5; i++) // Loop thru 6 but it was 5
            //for (int i = 0; i < 5; i++)
            {
                KanyeQuote();
                RonQuote();
            }
        }
    }
}

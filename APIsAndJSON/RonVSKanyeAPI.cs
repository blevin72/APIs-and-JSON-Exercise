using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void Kanye()
        {
            var client = new HttpClient();  //creating an instance of the Http Client
            var kanyeURL = "https://api.kanye.rest/";   //defining the URL for the API

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result; //sending an HTTP GET request (GetAsync) & receiving the response
                                                                        //as a string

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString(); //parse the JSON response (from above) using
                                                                                        //JObject (from the Newtonsoft.Json library)

            Console.WriteLine($"Kanye:{kanyeQuote}");  //printing the kanyeQuote (from above)
        }

        public static void Ron()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine($"Ron:{ronQuote}");
        }

    }
}

using RestSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Helpers;

namespace RestSharpSample
{
    public class ApiService
    {
        //https://openweathermap.org/current
        //http://api.openweathermap.org/data/2.5/weather?q=Columbus&appid=3910f84b72b87cb02ad1a8740805e414

        private string apiUrl = "http://api.openweathermap.org/data/2.5";
        private string apiRoute = "/weather?q=";
        private  string apiFragment = "&appid=";
        private  string apiKey = "3910f84b72b87cb02ad1a8740805e414";

        public Weather GetWeather(string city)
        {
            var client = new RestClient(apiUrl);
            RestRequest requestOne = new RestRequest(apiRoute + city + apiFragment + apiKey);
            IRestResponse response = client.Get(requestOne);
            CheckForError(response);
           
            // success
            string jsonString = response.Content;
            dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);

            //examine jsonResponse to find the data elements you want/need
            //you can do that with a running program in the debugger, or
            //you can use Postman, or (if all else fails) 
            //you can examine the api documentation

            Weather weather = new Weather();
            weather.Location = jsonResponse.name;
            weather.Description = jsonResponse.weather[0].main;

            weather.Temperature = jsonResponse.main.temp;
            weather.Temperature = (weather.Temperature - 273.15) * 9 / 5.0 + 32; //Kelvin to Farhrenheit

            //todo add feels_like to weather.FeelsLike and display

            return weather;
        }

    
        private void CheckForError(IRestResponse response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                //response not received
                throw new Exception("An error occurred - unable to reach the server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                //response indicating an error
                throw new Exception("An error response was received from the server. The status code is " + (int)response.StatusCode);
            }
            return;
        }
    }
}

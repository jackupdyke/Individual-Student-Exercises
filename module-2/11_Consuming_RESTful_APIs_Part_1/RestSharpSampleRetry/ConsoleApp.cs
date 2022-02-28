using System;
using System.Collections.Generic;

namespace RestSharpSample
{
    public class ConsoleApp
    {

        public void Run()
        {
            ApiService apiService = new ApiService();
            while (true)
            {
                PrintMainMenu();
                Console.Write("Please choose an option: ");
                int menuSelection = int.Parse(Console.ReadLine());

                if (menuSelection == 0)
                {
                    // Exit the loop
                    break;
                }

                else if (menuSelection == 1)
                {
                    //Columbus
                    Weather weather = apiService.GetWeather("Columbus");
                    PrintWeather(weather);
                }

                else if (menuSelection == 2)
                {
                    //Dallas
                    Weather weather = apiService.GetWeather("Dallas");
                    PrintWeather(weather);
                }

                else if (menuSelection == 3)
                {
                    //Atlanta
                    Weather weather = apiService.GetWeather("Atlanta");
                    PrintWeather(weather);
                }

                else if (menuSelection == 4)
                {
                    //San Diego
                    Weather weather = apiService.GetWeather("San Diego");
                    PrintWeather(weather);
                }
                else
                {
                    Console.WriteLine("Please enter a valid selection");
                }

            }
        }






        /************************************************************
          Print methods
        ************************************************************/
        public void PrintMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Weather");
            Console.WriteLine("-------------------");
            Console.WriteLine("1: Columbus");
            Console.WriteLine("2: Dallas");
            Console.WriteLine("3: Atlanta");
            Console.WriteLine("4: San Diego");
            Console.WriteLine("0: Exit");
            Console.WriteLine("---------");
        }


        /************************************************************
        Print weather
        ************************************************************/
        public void PrintWeather(Weather weather)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Location: " + weather.Location);
            Console.WriteLine("Description: " + weather.Description);
            Console.WriteLine("Temperature: " + weather.Temperature.ToString("N1"));
            
         
        }

    }
}

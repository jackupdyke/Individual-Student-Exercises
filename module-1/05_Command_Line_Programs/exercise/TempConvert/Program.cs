using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature: ");
            string userInput= Console.ReadLine();
            int temp = int.Parse(userInput);

            Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit? ");
            string unit = Console.ReadLine();

            
            if(unit == "F")
            {
                Console.WriteLine(temp + unit + " is " + (int)((temp - 32) / 1.8) + "C.");


            }
            else
            {
                Console.WriteLine(temp + unit + " is " + (int)(temp * 1.8 + 32) + "F.");
            }
        }
    }
}

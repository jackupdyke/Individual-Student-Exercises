using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");
            string userInput = Console.ReadLine();
            int length = int.Parse(userInput);

            Console.Write("Is the measurement in (m)eter, or (f)eet? ");
            string unit = Console.ReadLine();

            if(unit == "f")
            {
                Console.WriteLine(length + unit + " is " + (int)(length * 0.3048) + "m.");
            }
            else
            {
                Console.WriteLine(length + unit + " is " + (int)(length * 3.2808399) + "f.");
            }
        }
    }
}

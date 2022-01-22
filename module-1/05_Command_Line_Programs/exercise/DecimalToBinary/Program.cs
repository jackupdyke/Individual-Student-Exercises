using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in a series of decimal values (separated by spaces): ");
            string userInput = Console.ReadLine();

            string[] values = userInput.Split(" ");

            Console.WriteLine();

            for(int i = 0; i < values.Length; i++)
            {


                string binary = Convert.ToString(Convert.ToInt32(values[i], 10), 2);
                Console.WriteLine(values[i] + " in binary is " + binary);
            }


        }
    }
}

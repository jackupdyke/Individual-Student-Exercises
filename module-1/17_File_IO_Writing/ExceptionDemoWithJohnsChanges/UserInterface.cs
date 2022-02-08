using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionDemoWithJohnsChanges
{
    class UserInterface
    {

        public void Run()
        {
            bool done = false;

            while (!done)
            {

                Console.Write("Please enter a number with your choice: ");
                string result = Console.ReadLine();

                int number = 0;

                try
                {
                    number = int.Parse(result);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a valid number (5, 7, 13, etc.)");
                    continue;
                }

                Console.WriteLine($"You entered {number}.");

            }
        }
    }
}

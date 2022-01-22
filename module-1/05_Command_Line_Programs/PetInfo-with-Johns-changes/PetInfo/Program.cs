using System;

namespace PetInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for the numer of values to enter
            Console.WriteLine("Please a number of colors that you want to enter(3, 6, 7, etc.): ");

            //read input and parse to an integer
         
            string userInput = Console.ReadLine();
            int numberOfColors = int.Parse(userInput);

            //create a string array of the specificed size
            string[] colors = new string[numberOfColors];

            // prompt the use to enter the correct number values
            Console.WriteLine("Please enter " + numberOfColors + " colors, one per line.");

            // loop the correct  number of times
            for(int i = 0; i < numberOfColors; i++)
            {
                //get a string
                //put in into the array
                colors[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Here are the colors that you entered:");

            // loop the corect number of times
            //display the contents of the array

            for (int i = 0; i < numberOfColors; i++)
            {
                Console.WriteLine(colors[i]);
            }

            //thank the user

            Console.WriteLine("Thank you for using our program!");

                return;
        }
    }
}

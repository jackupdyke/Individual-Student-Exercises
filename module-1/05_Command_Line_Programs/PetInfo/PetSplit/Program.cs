using System;

namespace PetSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //primpt the user to enter several words seperated by spaces
            Console.Write("Please enter several words seperated by spaces: ");

            //read in the string
            string userInput = Console.ReadLine();


            //split the strin to an array
            string[] words = userInput.Split(" ");


            //loop through the array and display the results, on eline at a time.
            Console.WriteLine();
            Console.WriteLine("Here are the words you entered: ");

            for(int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]);
            }

            Console.WriteLine("Thank you for using our program!");

            return;
        }
    }
}

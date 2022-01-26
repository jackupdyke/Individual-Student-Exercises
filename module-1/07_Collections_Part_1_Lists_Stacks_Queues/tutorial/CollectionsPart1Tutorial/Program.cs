using System;
using System.Collections.Generic;

namespace CollectionsPart1Tutorial
{
    public class CollectionsPart1Tutorial
    {
        static void Main(string[] args)
        {

            // Step One: Declare a List


            List<string> name = new List<string>();

            // Step Two: Add values to a List


            name.Add("Ada");
            name.Add("Grace");
            name.Add("Margeret");
            name.Add("Adele");

            // Step Three: Looping through a List in a for loop

            for(int i = 0; i < name.Count; i++)
            {
                Console.WriteLine("The name at index " + i + " is " + name[i]);
            }


            // Step Four: Remove an item


            name.Remove("Ada");

            // Step Five: Looping through List in a foreach loop

            foreach(string names in name)
            {
                Console.WriteLine("Name: " + names);
            }


        }
    }
}

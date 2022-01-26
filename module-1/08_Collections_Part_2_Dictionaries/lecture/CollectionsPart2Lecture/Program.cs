using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();

			// create a dictionary
			Dictionary<string, string> pets = new Dictionary<string, string>();

			pets.Add("Bella", "dog");
			pets["Primrose"] = "cat";
			pets["Gabriel"] = "cat";
			pets["Penny"] = "cat";
            pets["Fish1"] = "fish";
            pets["Fish2"] = "fish";

            Console.WriteLine(pets["Gabriel"]);
            Console.WriteLine("##########");

			foreach(string name in pets.Keys)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("#########");
            
			if(pets.ContainsKey("Fish1"))
            {
                Console.WriteLine("Fish1 exists");
                Console.WriteLine("and is of type " + pets["Fish1"]);
            }
            else
            {
                pets["Fish1"] = "fish";
                Console.WriteLine("Fish1 has been created.");
            }

            Console.WriteLine("#########");


            bool result = pets.Remove("Fish1");
            if(result)
            {
                Console.WriteLine("removed Fish1");
            }
            else
            {
                Console.WriteLine("Did not remove Fish1");
            }

            foreach (string name in pets.Keys)
            {
                Console.WriteLine(name);
            }

            foreach(KeyValuePair<string, string> item in pets)
            {
                Console.WriteLine($"The pet  {item.Key}  is a  {item.Value}");
            }

            HashSet<string> students = new HashSet<string>();
            students.Add("student1");
            students.Add("student2");
            students.Add("student3");
            students.Add("student1");

            foreach(string student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("##########");


            string[] temp = new string[students.Count];
            students.CopyTo(temp);

            List<string> myList = new List<string>();
            myList.AddRange(temp);

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

        }
    }
}

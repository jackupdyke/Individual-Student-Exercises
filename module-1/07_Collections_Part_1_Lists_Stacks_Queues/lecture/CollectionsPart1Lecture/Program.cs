using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<string> names = new List<string>()
			{
				"fish1", "fish2", "fish3"
			};
			List<int> numbers = new List<int>();


			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			names.Add("Bella");
			names.Add("Primrose");
			names.Add("Gabriel");

			foreach(string name in names)
            {
                Console.WriteLine(name);
            }

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			names.Add("Gabriel");

			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			int count = names.Count;
			int middle = count / 2;

			names.Insert(middle, "fish4");

			foreach (string name in names)
			{
				Console.WriteLine(name);
			}
			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			names.RemoveAt(5);

			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

            if (names.Contains("Primrose"))
            {
                Console.WriteLine("Primrose found.");
            }
            else
            {
                Console.WriteLine("Primrose not found.");
            }

            Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			int location = names.IndexOf("Gabriel");

			Console.WriteLine("Gabriel found at index " + location) ;

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");


			string[] result = names.ToArray();

			foreach (string name in result)
			{
				Console.WriteLine(name);
			}

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");

			names.Sort();

			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			names.Reverse();

			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();


		}
	}
}

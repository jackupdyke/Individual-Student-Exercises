using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // OLD MACDONALD
            //
            ISingable[] items = new ISingable[] { new Cow(), new Chicken(), new Dog(), new Pig(), new Tractor() };

            foreach (ISingable item in items)
            {
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + item.Name + ", ee ay ee ay oh!");
                Console.WriteLine("With a " + item.Sound + " " + item.Sound + " here");
                Console.WriteLine("And a " + item.Sound + " " + item.Sound + " there");
                Console.WriteLine("Here a " + item.Sound + " there a " + item.Sound + " everywhere a " + item.Sound + " " + item.Sound);
                Console.WriteLine();
            }
            Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");

            List<ISellable> forSale = new List<ISellable>() { new Cow(), new Chicken(), new Pig(), new Tractor() };
            
            foreach(ISellable item in forSale)
            {
                Console.WriteLine($"Item: {item.Name} = {item.Price.ToString("C")}");
            }
            
        }
    }
}

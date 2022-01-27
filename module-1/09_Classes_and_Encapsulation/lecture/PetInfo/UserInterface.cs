using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class UserInterface
    {
        public void Run()
        {
            Console.WriteLine("Welcome to Pet Info");

            Pet dog = new Pet();
            dog.PetType = "dog";
            dog.PetAge = 4;
            //dog.Color = "black";
            dog.EyeColor = "Brown";
            //Console.WriteLine(dog.petName + " " + dog.PetType + " " + dog.PetAge + " " + dog.Color);

            Console.WriteLine(dog.DisplayInfo());

            Console.ReadLine();

            return;
        }
        
    }
}



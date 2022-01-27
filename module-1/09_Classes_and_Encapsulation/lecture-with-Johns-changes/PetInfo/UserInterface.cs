using System;

namespace PetInfo
{
    public class UserInterface
    {
        public void Run()
        {
            Console.WriteLine("Welcome to Pet Info");

            Pet dog = new Pet();
            dog.petName = "Bella";
            dog.PetType = "dog";
            dog.PetAge = 4;
            //dog.Color = "Black;" Not allowed
            dog.EyeColor = "Brown";
            
            Pet dog2 = new Pet("Yoshi");
            //dog2.petName = "Yoshi";
            dog2.SetColor("Black");

            Pet dog3 = new Pet();


            //Console.WriteLine(dog.petName + " " + dog.PetType + " " + 
            //    dog.PetAge + " " + dog.Color);

            //Console.WriteLine(dog2.petName + " " + dog2.PetType + " " +
            //    dog2.PetAge + " " + dog2.Color);

            Console.WriteLine(dog.DisplayInfo());
            Console.WriteLine(dog2.DisplayInfo());
            Console.WriteLine(dog3.DisplayInfo());

            //Console.WriteLine(dog3.petName);

            Console.ReadLine();

            return;
        }

    }
}

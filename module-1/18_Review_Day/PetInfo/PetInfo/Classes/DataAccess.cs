using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PetInfo
{
    class DataAccess
    {
        private string filename = @"C:\PetInfo\data.csv";

        public Dictionary<int, Pet> GetPets()
        {
            Dictionary < int, Pet> pets = new Dictionary<int, Pet>();

            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(',');

                    Pet pet = new Pet();
                    pet.Id = int.Parse(split[0]);
                    pet.Name = split[1];
                    pet.Type = split[2];
                    pet.Breed = split[3];

                    pets.Add(pet.Id, pet);
                }
            }

            return pets;
        }
    }
}


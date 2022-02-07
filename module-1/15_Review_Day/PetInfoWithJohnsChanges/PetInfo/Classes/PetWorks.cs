using System.Collections.Generic;

namespace PetInfo
{
    public class PetWorks
    {
        private List<Pet> pets = new List<Pet>();

        public Pet AddAPet(int id, string name, string type, string breed)
        {
            Pet pet = new Pet(id, name, type, breed);
            pets.Add(pet);

            return pet;
        }

        public Pet[] GetPets()
        {
            return pets.ToArray();
        }

        public bool DeleteAPet(int id)
        {
            int i = 0;

            for (i = 0; i < pets.Count; i++)
            {
                if (pets[i].Id == id)
                {
                    break;
                }
            }

            if (i < pets.Count)
            {
                pets.RemoveAt(i);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

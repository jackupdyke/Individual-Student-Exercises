using PetInfo;
using System.Collections.Generic;

namespace PetInfoServer.DAL.Interfaces
{
    public interface IPetDAO
    {
        List<Pet> GetPets();
        Pet GetPet(int petId);
        bool AddPet(string name, string type, string breed);
        bool AddPet(Pet pet);
        bool DeletePet(int id);
        bool UpdatePet(Pet pet);
    }
}

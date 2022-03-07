using PetInfoServer.Models;
using System.Collections.Generic;


namespace PetInfoServer.DAL.Interfaces
{
    public interface IOwnerDAO
    {
        List<Owner> GetOwners();
    }
}

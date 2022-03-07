using Microsoft.AspNetCore.Mvc;
using PetInfoServer.DAL.Interfaces;
using PetInfoServer.Models;
using System.Collections.Generic;

namespace PetInfoServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private IOwnerDAO ownerDAO;

        public OwnerController( IOwnerDAO ownerDAO)
        {
            this.ownerDAO = ownerDAO;
        }

        [HttpGet()]
        public ActionResult<List<Owner>> GetOwners()
        {
            List<Owner> owners = ownerDAO.GetOwners();
            if(owners.Count == 0)
            { 
                return NotFound(); 
            }
            else
            {
                return Ok(owners);
            }
        }
    }
}

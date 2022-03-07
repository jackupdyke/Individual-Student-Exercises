﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetInfo;
using PetInfoServer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetInfoServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private IPetDAO petDAO;

        public PetController(IPetDAO petDAO)
        {
            this.petDAO = petDAO;
        }


        //GET: /pet
        [HttpGet]
        public ActionResult<List<Pet>> getPets()
        { 
            List<Pet> pets = petDAO.GetPets();

            if (pets.Count > 0)
            {
                return Ok(pets);
            }
            else
            {
                return NotFound();
            }
        }
    }
}

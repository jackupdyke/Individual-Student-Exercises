using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetInfoServer.DAL.Interfaces;
using PetInfoServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PetInfoServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class ActivityController : ControllerBase
    {

        private IActivityDAO activityDAO;

        public ActivityController(IActivityDAO activityDAO)
        {
            this.activityDAO = activityDAO;
        }

        //GET: /activity
        [HttpGet()]
        public ActionResult<List<Activity>> GetActivities()
        {
            List<Activity> activities = activityDAO.GetActivities();
            if (activities.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(activities);
            }
        }

    }
}

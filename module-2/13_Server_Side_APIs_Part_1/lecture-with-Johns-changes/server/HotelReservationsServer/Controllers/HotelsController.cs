using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.DAO;

namespace HotelReservations.Controllers
{
    //http://localhost:<portnumber>/hotels
    [Route("hotels")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private static IHotelDao hotelDao;

        public HotelsController()
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
        }

        [HttpGet("ready")]
        // GET /hotels/ready
        public string Ready()
        {
            return "Server is ready for your use.";
        }


        [HttpGet()]
        // GET /hotels
        public List<Hotel> ListHotels()
        {
            return hotelDao.List();
        }

        [HttpGet("{id}")]
        // GET /hotels/2
        public ActionResult<Hotel> GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("filter")]
        // GET /hotels/filter?city=Columbus
        public ActionResult<List<Hotel>> GetHotelsByCity(string city = "")
        {
            List<Hotel> result = hotelDao.GetListByCity(city);
            return result;

        }
    }
}

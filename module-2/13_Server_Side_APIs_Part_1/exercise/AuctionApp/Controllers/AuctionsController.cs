using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionMemoryDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        [HttpGet("ready")]
        public string Ready()
        {
            return "Server ready.";
        }

        [HttpGet()]
        public ActionResult<List<Auction>> GetAuctions(string title_like = "", double currentBid_lte = 0)
        {


            if (title_like == "" && currentBid_lte == 0)
            {
                return dao.List();
            }
            else if (title_like != null && currentBid_lte > 0)
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte); 
            }
            else if(title_like != null)
            {
                return dao.SearchByTitle(title_like);
            }
            else if(currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            
            else
            {
                return null;
            }
           

        }

        [HttpGet("{id}")]
        public ActionResult<Auction> GetAuction(int id)
        {
            Auction auction = dao.Get(id);

            return auction;

        }

        [HttpPost()]
        public ActionResult<Auction> AddAuction(Auction auction)
        {
            Auction result = dao.Create(auction);

            return result;

        }

        



        
    }
}


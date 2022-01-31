using System;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// A buyout auction sets a buyout price that the bidder can use allowing
    /// the auction to end.
    /// </summary>
    public class BuyoutAuction : Auction
    {


        //constructor  BuyoutAuction(int buyoutPrice)
        public BuyoutAuction(int buyoutPrice)
        {
            BuyoutPrice = buyoutPrice;
        }

        // read-only property BuyoutPrice
        
        public int BuyoutPrice{get; }
        //override the parent's PlaceBiD method
        public override bool PlaceBid(Bid offeredBid)
        {
            //bids are only considerd if the buy-out price hasn't been reached yet
            if (offeredBid.BidAmount <= BuyoutPrice)
            {
               return base.PlaceBid(offeredBid);
            }
            else
            {
                Console.WriteLine("Buyout amount has already been reached.");
                return false;
            }
            
        }
        

    }
}

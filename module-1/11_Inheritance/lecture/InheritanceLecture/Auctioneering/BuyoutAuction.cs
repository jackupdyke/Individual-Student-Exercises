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

        // read-only property BuyoutPrice

        //override the parent's PlaceBiD method
        //bids are only considerd if the buy-out price hasn't been reached yet
       
    }
}

using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
     class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            //Console.WriteLine("Starting a general auction");
            //Console.WriteLine("-----------------");

            //Auction generalAuction = new Auction();

            //generalAuction.PlaceBid(new Bid("Josh", 1));
            //generalAuction.PlaceBid(new Bid("Fonz", 23));
            //generalAuction.PlaceBid(new Bid("Rick Astley", 13));
            ////....
            ////....
            //// This might go on until the auction runs out of time or hits a max # of bids




            //BuyoutAuction buyoutAuction = new BuyoutAuction(100);

            //buyoutAuction.PlaceBid(new Bid("John", 50));
            //buyoutAuction.PlaceBid(new Bid("Chris", 75));
            //buyoutAuction.PlaceBid(new Bid("John", 100));
            //buyoutAuction.PlaceBid(new Bid("Chris", 125));

            ReserveAuction reserveAuction = new ReserveAuction(75);

            reserveAuction.PlaceBid(new Bid("John", 50));
            reserveAuction.PlaceBid(new Bid("Chris", 75));
            reserveAuction.PlaceBid(new Bid("John", 100));
            reserveAuction.PlaceBid(new Bid("Chris", 125));


            //StaticDemo myDemo = new StaticDemo();
            //StaticDemo.Print();

            //Console.ReadLine();
        }
    }
}

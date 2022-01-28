using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class UserInterface
    {
        private Deck deck = new Deck();
        
        public void Run()
        {
            bool done = false;

            while(!done)
            {
                DisplayMenu();

                int selection = int.Parse(Console.ReadLine());

                switch(selection)
                {
                    case (1):
                        DisplayDeck();
                        break;
                    case (2):
                        DealACard();
                        break;
                    case (0):
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid value.");
                        break;
                }
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1 - Display deck");
            Console.WriteLine("2 - Deal a card");
            Console.WriteLine();
            Console.WriteLine("0 - End program");
            Console.WriteLine();
            Console.Write("Please enter a number: ");
        }

        private void DisplayDeck()
        {
            Card[] cards = deck.GetDeck();

            Console.WriteLine("Here is your deck: ");
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Suit + " - " + card.Value);
            }
        }

        private void DealACard()
        {
            Console.WriteLine("Reached DealACard");
        }


        //todo create menu
        //todo examine deck
        //todo deal a card
    }
}

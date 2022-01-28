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

                switch (selection)
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
                        Console.WriteLine("Please Enter a Valid Value.");
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
            Console.WriteLine("1 - Display Deck");
            Console.WriteLine("2 - Deal a Card");
            Console.WriteLine();
            Console.WriteLine("0 - End Program");
            Console.WriteLine();
            Console.Write("Please Enter a Number: ");
               
        }

       private void DisplayDeck()
        {
            Card[] cards = deck.GetDeck();

            Console.WriteLine("Here is your deck: ");
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Suit + " - " + card.Value);
            }
            Console.WriteLine("Reached DisplayDeck");
            
        }

        private void DealACard()
        {
            Console.WriteLine("Reached DealACard");
        }

        //todo create menu
        //todo examine a deck
        //todo deal a card
    }
}

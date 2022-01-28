using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class Deck
    {
        private List<Card> deck = new List<Card>();

        public Deck()
        {
            string[] suits = { "S", "H", "D", "C" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    Card card = new Card(suits[i], values[j]);
                    deck.Add(card);
                }
            }
        }

        public Card[] GetDeck()
        {
            return deck.ToArray();
        }

        //todo create a deck
        //todo shuffle deck ?
        //todo deal a card
    }
}

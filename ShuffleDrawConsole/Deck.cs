using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ShuffleDrawConsole
{
    public class Deck
    {
        private static List<Card> Cards;

        public Deck()
        {
            LoadDeck();
        }

        private void LoadDeck()
        {            
            Cards = new List<Card>();
            foreach (var suit in new[] { "Spades", "Hearts", "Clubs", "Diamonds", })
            {
                for (var ctr = 1; ctr <= 13; ctr++)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.CardValue = CardValue(ctr);
                    Cards.Add(card);
                }
            }          
        }

        private string CardValue(int ctr)
        {
            string cardValue = ctr.ToString();

            switch (ctr)
            {
                case 1:
                    cardValue = "Ace";
                    break;
                case 11:
                    cardValue = "Jack";
                    break;
                case 12:
                    cardValue = "Queen";
                    break;
                case 13:
                    cardValue = "King";
                    break;
            }
            
            return cardValue;
        }
        public List<Card> Shuffle()
        {
            List<Card> shuffled = Cards.OrderBy(x => Guid.NewGuid()).ToList();

            return shuffled;
        }
    }
}

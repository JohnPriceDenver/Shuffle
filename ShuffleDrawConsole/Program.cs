using System;
using System.Collections.Generic;

namespace ShuffleDrawConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deckOfCards = new Deck();

            List<Card> shuffled = deckOfCards.Shuffle();

            foreach (var card in shuffled)
            {
                Console.WriteLine(card.CardValue.ToString() + " of " + card.Suit);
            }

            Console.ReadLine();
        }
    }
}

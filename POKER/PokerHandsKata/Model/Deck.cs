using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHandsKata.Model
{
    public class Deck
    {
        public readonly IList<Card> Cards;

        public Deck(int seed)
        {
            var d = GenerateDeck(seed);
            Cards = splitCards(d);
        }

        private IList<Card> splitCards(string cards)
        {
            return cards.TrimEnd().Split(' ')
                        .Select(c => new Card(c))
                        .ToList();
        }

        public static string GenerateDeck(int seed)
        {
            var cards = string.Empty;

            String[] suit = { "C", "S", "H", "D" };
            String[] rank = 
            { 
                "2", "3", "4", "5", "6", "7", "8", "9", "10", 
                "J", "Q", "K", "A" 
            };

            // initialize cards in a deck
            var deck = new String[suit.Length * rank.Length];
            for (var i = 0; i < rank.Length; i++)
                for (var j = 0; j < suit.Length; j++)
                    deck[suit.Length*i + j] = rank[i] + suit[j];

            // shuffle deck
            var d = deck.Length;
            var rand = new Random(seed);

            for (var i = 0; i < d; i++)
            {
                var r = i + (int) (rand.NextDouble()  * (d-i));
                var temp = deck[r];
                deck[r] = deck[i];
                deck[i] = temp;
            }

            var generateDeck = deck.Aggregate(cards, (current, s) => current + (s + " "));

            Console.WriteLine(generateDeck);

            return generateDeck;
        }

        public List<Hand> GetHandsFor(int nbPlayers)
        {
            var hands = new List<Hand>(nbPlayers);

            for (var i = 0; i < nbPlayers; i++)
            {
                var h = new Hand();

                var index = 0;
                while (h.Cards.Count < 5)
                {
                    var card = Cards[i + index];
                    h.Cards.Add(card);
                    index = index + nbPlayers;
                }
                
                hands.Add(h);
            }
            return hands;
        }

    }
}

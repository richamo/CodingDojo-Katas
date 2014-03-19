using System.Collections.Generic;
using System.Linq;

namespace PokerHandsKata.Model
{
    public class Hand
    {
        public readonly IList<Card> Cards;

        public Hand(string cards = "")
        {
            Cards = new List<Card>();

            if (!string.IsNullOrEmpty(cards))
            {
                Cards = splitCards(cards);
            }
        }

        private IList<Card> splitCards(string cards)
        {
            return cards.TrimEnd().Split(' ')
                        .Select(c => new Card(c))
                        .ToList();
        }
    }
}

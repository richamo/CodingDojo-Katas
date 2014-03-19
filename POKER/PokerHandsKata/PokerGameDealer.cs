using System;
using System.Collections.Generic;
using PokerHandsKata.Model;

namespace PokerHandsKata
{
    public class PokerGameDealer : IPokerGameDealer
    {
        public Score GetScore(Hand hand)
        {
            throw new NotImplementedException();
        }

        public Hand GetWinnerHand(IList<Hand> hands)
        {
            throw new NotImplementedException();
        }
    }
}
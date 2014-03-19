using System.Collections.Generic;
using PokerHandsKata.Model;

namespace PokerHandsKata
{
    public interface IPokerGameDealer
    {
        Score GetScore(Hand hand);

        Hand GetWinnerHand(IList<Hand> hands);
    }
}
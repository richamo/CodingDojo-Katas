using System.Collections.Generic;
using System.Linq;
using PokerHandsKata.Model;

namespace PokerHandsKata
{
    public class PokerGame
    {
        private static IPokerGameDealer _dealer;

        public static IPokerGameDealer Dealer
        {
            get { return _dealer ?? (_dealer = new DummyPokerGameDealer()); }
            //get { return _dealer ?? (_dealer = new PokerGameDealer()); }
            set { _dealer = value; }
        }

        public static Score GetScore(Hand hand)
        {
            return Dealer.GetScore(hand);
        }

        public static Hand GetWinnerHand(IList<Hand> hands)
        {
            return Dealer.GetWinnerHand(hands);
        }
    }

    public class DummyPokerGameDealer : IPokerGameDealer
    {
        public Score GetScore(Hand hand)
        {
            return Score.HighCard;
        }

        public Hand GetWinnerHand(IList<Hand> hands)
        {
            return hands.First();
        }
    }
}

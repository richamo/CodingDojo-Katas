using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using PokerHandsKata;
using PokerHandsKata.Model;

namespace K3.Test
{
    [TestClass]
    public class PokerGameTests
    {
        Hand h;

        private void CreateHand(string hand)
        {
            h = new Hand(hand);
        }

        [TestMethod]
        public void ShouldBeHighCard()
        {
            CreateHand("2H 6S 9S KS JD");
            Check.That(PokerGame.GetScore(h)).Equals(Score.HighCard);
            //Assert.AreEqual(Score.HighCard, PokerGame.GetScore(h));
        }

        [TestMethod]
        public void ShouldBePair()
        {
            CreateHand("2H 6C 9S 2D JD");
            Check.That(PokerGame.GetScore(h)).Equals(Score.Pair);
            //Assert.AreEqual(Score.Pair, PokerGame.GetScore(h));
        }

        //[TestMethod]
        //public void ShouldBeTwoPair()
        //{
        //    CreateHand("2H 6C 2S 6H QD");
        //    Check.That(PokerGame.GetScore(h)).Equals(Score.TwoPair);
        //    //Assert.AreEqual(Score.TwoPair, PokerGame.GetScore(h));
        //}

        //[TestMethod]
        //public void ShouldBeThreeOfAKind()
        //{
        //    CreateHand("2H 2S 8C QH 2D");
        //    Check.That(PokerGame.GetScore(h)).Equals(Score.ThreeOfAKind);
        //    //Assert.AreEqual(Score.ThreeOfAKind, PokerGame.GetScore(h));
        //}

        //[TestMethod]
        //public void ShouldBeStraight()
        //{
        //    CreateHand("4H 8S 6D 5C 7H");
        //    Check.That(PokerGame.GetScore(h)).Equals(Score.Straight);
        //    //Assert.AreEqual(Score.Straight, PokerGame.GetScore(h));

        //    CreateHand("AS 5D 4H 2C 3S");
        //    Check.That(PokerGame.GetScore(h)).Equals(Score.Straight);
        //    //Assert.AreEqual(Score.Straight, PokerGame.GetScore(h));
        //}

        //[TestMethod]
        //public void ShouldBeFlush()
        //{
        //    CreateHand("4H 8H AH 5H 2H");
        //    Check.That(PokerGame.GetScore(h)).Equals(Score.Flush);
        //    //Assert.AreEqual(Score.Flush, PokerGame.GetScore(h));
        //}

        //[TestMethod]
        //public void ShouldBeFullHouse()
        //{
        //    CreateHand("4D 9S 9D 4H 4C");
        //    Check.That(PokerGame.GetScore(h)).Equals(Score.FullHouse);
        //    //Assert.AreEqual(Score.FullHouse, PokerGame.GetScore(h));
        //}

        //[TestMethod]
        //public void ShouldBeFourOfAKind()
        //{
        //    CreateHand("AS AD 9S AC AH");
        //    Assert.AreEqual(Score.FourOfAKind, PokerGame.GetScore(h));
        //}

        //[TestMethod]
        //public void ShouldBeStraightFlush()
        //{
        //    CreateHand("9S 10S JS QS KS");
        //    Check.That(PokerGame.GetScore(h)).Equals(Score.StraightFlush);
        //    //Assert.AreEqual(Score.StraightFlush, PokerGame.GetScore(h));
        //}

        //[TestMethod]
        //public void ShouldBeRoyalFlush()
        //{
        //    CreateHand("10S JS QS KS AS");
        //    Check.That(PokerGame.GetScore(h)).Equals(Score.RoyalFlush);
        //    //Assert.AreEqual(Score.RoyalFlush, PokerGame.GetScore(h));
        //}
    }
}

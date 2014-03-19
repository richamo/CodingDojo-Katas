using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using PokerHandsKata.Model;

namespace K3.Test
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void ShouldHaveJustOneCard()
        {
            Hand h = new Hand("2H");

            Check.That(h.Cards.Count).Equals(1);
            Check.That(h.Cards[0].NumberValue).Equals(2);
            Check.That(h.Cards[0].Suit).Equals("H");
            //Assert.AreEqual(1, h.Cards.Count);
            //Assert.AreEqual(2, h.Cards[0].NumberValue);
            //Assert.AreEqual("H", h.Cards[0].Suit);
        }

        [TestMethod]
        public void ShouldSplitTheStringOfCards()
        {
            var cards = new Hand("2H AS").Cards;

            Check.That(cards[0].NumberValue).Equals(2);
            Check.That(cards[0].Suit).Equals("H");
            Check.That(cards[1].NumberValue).Equals(14);
            Check.That(cards[1].Suit).Equals("S");

            //Assert.AreEqual(2, cards[0].NumberValue);
            //Assert.AreEqual("H", cards[0].Suit);
            //Assert.AreEqual(14, cards[1].NumberValue);
            //Assert.AreEqual("S", cards[1].Suit);
        }
    }
}

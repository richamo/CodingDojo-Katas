using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandsKata;
using PokerHandsKata.Model;
using NFluent;

namespace K3.Test
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void ShouldReturn6ForNumberValueAndHForSuit()
        {
            Card c = new Card("6H");

            Check.That(c.NumberValue).Equals(6);
            Check.That(c.Suit).Equals("H");
            //Assert.AreEqual(6, c.NumberValue);
            //Assert.AreEqual("H", c.Suit);
        }

        [TestMethod]
        public void ShouldReturn12ForNumberValueAndCForSuit()
        {
            Card c = new Card("QC");

            Check.That(c.NumberValue).Equals(12);
            Check.That(c.Suit).Equals("C");
            //Assert.AreEqual(12, c.NumberValue);
            //Assert.AreEqual("C", c.Suit);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowExceptionOnInvalidCardNumber()
        {
            Card c0 = new Card("22H");
            Card c1 = new Card("0H"); 
            Card c2 = new Card("PH"); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowExceptionOnInvalidSuit()
        {
            Card c = new Card("2X");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowExceptionOnInvalidCard()
        {
            Card c = new Card("");
        }

        [TestMethod]
        public void ShouldReturnTheRightToString()
        {
            Card c = new Card("QC");

            Check.That(c.ToString()).Equals("QC");
            //Assert.AreEqual("QC", c.ToString());
        }
    }
}

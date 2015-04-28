using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace FruitShop.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenPommeShouldReturn100()
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("Pomme");
            Assert.AreEqual(100, panier);

        }

        [TestMethod]
        public void WhenBananeShouldReturn150()
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("Banane");
            Assert.AreEqual(150, panier);

        }

        [TestMethod]
        public void WhenCerisesShouldReturn75()
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("Cerise");
            Assert.AreEqual(75, panier);

        }
        
        [TestMethod]
        public void WhenAddPommeToPommeShouldReturn200()
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("Pomme");
            panier = caisse.AddFruit("Pomme");
            Assert.AreEqual(200, panier);
        }

        [TestMethod]
        public void WhenAddTwoCeriseApplyDiscount()
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Cerise");
            Assert.AreEqual(130, panier);
        }

        [TestMethod]
        [Ignore]
        public void WhenPommeCeriseBananeShouldReturn325()
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("pomme, cerise, banane");
            
            Assert.AreEqual(325, panier);
        }

        [TestMethod]
        [Ignore]
        public void WhenIteration3ShouldReturn610()
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Pomme");
            panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Banane");
            panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Pomme");
            Assert.AreEqual(610, panier);
        }

        [TestMethod]
        [Ignore]
        public void WhenIteration3ShouldReturn555()
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Pomme");
            panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Banane");
            panier = caisse.AddFruit("Pomme");
            panier = caisse.AddFruit("Banane");
            panier = caisse.AddFruit("Cerise");
            Assert.AreEqual(555, panier);

            
        }

        [TestMethod]
        [Ignore]
        public void WhenIteration4ShouldReturn380()   
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Apple");
            panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Banane");
            panier = caisse.AddFruit("Banane");


            Assert.AreEqual(380, panier);

        }

        [TestMethod]
        [Ignore]
        public void WhenIteration4LanguesShouldReturn580()
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Apple");
            panier = caisse.AddFruit("Cerise");
            panier = caisse.AddFruit("Banane");
            panier = caisse.AddFruit("Pomme");
            panier = caisse.AddFruit("Mele");


            Assert.AreEqual(580, panier);

        }



        [TestMethod]
        public void WhenTwoBananeReturnOne()
        {
            var caisse = new Caisse();
            int panier = caisse.AddFruit("Banane");
            panier = caisse.AddFruit("Banane");
           // Assert.AreEqual(150, panier);

            Assert.AreEqual(150, panier);
        }

        [TestMethod]
        [Ignore]
        public void WhenIteration5PrimeLocalisationShouldReturn680()
        {
            var caisse = new Caisse();

            string fruits = "Mele, Apple, Apple, Pomme, Apple, Mele, Cerise, Cerise, banane";

            int panier = caisse.AddFruit(fruits);

            Assert.AreEqual(680, panier);

        }

        [TestMethod]
        public void WhenIteration6Test1ShouldReturn200()
        {
            var caisse = new Caisse();

            string fruits = "Mele, Apple, Apple, Mele";

            int panier = caisse.AddFruit(fruits);

            Assert.AreEqual(200, panier);

        }

        [TestMethod]
        public void WhenIteration6Test2ShouldReturn100()
        {
            var caisse = new Caisse();

            string fruits = "Mele, Apple, Apple, Pomme, Mele";

            int panier = caisse.AddFruit(fruits);

            Assert.AreEqual(100, panier);

        }

    }
}

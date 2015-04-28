using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeDojo.Model;

namespace CodeDojo.TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cashier cashier = new Cashier();

            Product apple = new Product(){Name="Apple",Price=100};
            Product cherrie = new Product(){Name="Cherrie",Price=75};
            Product banana = new Product(){Name="Banana",Price=150};

            cashier.Add(apple);
            cashier.Add(cherrie);
            cashier.Add(banana);

            Assert.AreEqual("325", cashier.ToString());

        }

        [TestMethod]
        public void TestMethod2()
        {
            Cashier cashier = new Cashier();

            Product apple = new Product() { Name = "Apple", Price = 100 };
            Product cherrie = new Product() { Name = "Cherrie", Price = 75 };
            Product banana = new Product() { Name = "Banana", Price = 150 };


            cashier.AddPromotion(new Promotion()
            {
                ProductName = "Cherrie",
                Remise = 20,
                QuantityTrigger = 2
            });


            cashier.Add(apple);
            cashier.Add(cherrie);
            cashier.Add(cherrie);
            cashier.Add(banana);

            Assert.AreEqual("380", cashier.ToString());

        }

        [TestMethod]
        public void TestMethod3()
        {
            Cashier cashier = new Cashier("En");

            Product appleEn = new Product() { Name = "Apple",CountryCode="En",TranslationName="Apple", Price = 100 };
            Product appleFr = new Product() { Name = "Apple", CountryCode = "Fr", TranslationName = "Pomme", Price = 100 };


            Product cherrie = new Product() { Name = "Cherrie", CountryCode = "En", Price = 75 };
            Product banana = new Product() { Name = "Banana", CountryCode = "En", Price = 150 };


            cashier.AddPromotion(new Promotion()
            {
                ProductName = "Cherrie",
                Remise = 30,
                QuantityTrigger = 2,
                CountryCode = "En"
            });
            cashier.AddPromotion(new Promotion()
            {
                ProductName = "Banana",
                Remise = 150,
                QuantityTrigger = 2,
                CountryCode = "En"
            });


            cashier.Add(appleEn);
            cashier.Add(cherrie);
            cashier.Add(cherrie);
            cashier.Add(banana);
            cashier.Add(banana);

            Assert.AreEqual("370", cashier.ToString());
        }

        [TestMethod]
        public void TestMethod4()
        {
            Cashier cashier = new Cashier();

            Product apple = new Product() { Name = "Apple", Price = 100 };
            Product cherrie = new Product() { Name = "Cherrie", Price = 75 };
            Product banana = new Product() { Name = "Banana", Price = 150 };


            cashier.AddPromotion(new Promotion()
            {
                ProductName = "Cherrie",
                Remise = 30,
                QuantityTrigger = 2
            });
            cashier.AddPromotion(new Promotion()
            {
                ProductName = "Banana",
                Remise = 150,
                QuantityTrigger = 2
            });


            cashier.Add(apple);
            cashier.Add(cherrie);
            cashier.Add(cherrie);
            cashier.Add(banana);
            cashier.Add(banana);

            Assert.AreEqual("370", cashier.ToString());
        }


        [TestMethod]
        public void TestMethod6()
        {
            Cashier cashier = new Cashier("En");

            Product appleEn = new Product() { Name = "Apple", CountryCode = "En", TranslationName = "Apple", Price = 100 };
            Product appleFr = new Product() { Name = "Apple", CountryCode = "Fr", TranslationName = "Pomme", Price = 100 };


            Product cherrie = new Product() { Name = "Cherrie", CountryCode = "En", Price = 75 };
            Product banana = new Product() { Name = "Banana", CountryCode = "En", Price = 150 };


            cashier.AddPromotion(new Promotion()
            {
                ProductName = "Cherrie",
                Remise = 30,
                QuantityTrigger = 2,
                CountryCode = "En"
            });
            cashier.AddPromotion(new Promotion()
            {
                ProductName = "Banana",
                Remise = 150,
                QuantityTrigger = 2,
                CountryCode = "En"
            });

            cashier.AddPromotion(new Promotion()
            {
                ProductName = "Apple",
                Remise = 100,
                QuantityTrigger = 4,
                CountryCode = "En"
            });

            cashier.AddPromotion(new Promotion()
            {
                ProductName = "",
                Remise = 200,
                QuantityTrigger = 5,
                CountryCode = "En"
            });


            cashier.Add(appleEn);
            cashier.Add(cherrie);
            cashier.Add(cherrie);
            cashier.Add(banana);
            cashier.Add(banana);

            Assert.AreEqual("170", cashier.ToString());

            cashier = new Cashier("En");
            cashier.Add(appleEn);
            cashier.Add(cherrie);
            cashier.Add(cherrie);
            cashier.Add(banana);
            cashier.Add(banana);

            cashier.Add(appleEn);
            cashier.Add(cherrie);
            cashier.Add(cherrie);
            cashier.Add(banana);
            cashier.Add(banana);
            Assert.AreEqual("370", cashier.ToString());


        }
    }
}

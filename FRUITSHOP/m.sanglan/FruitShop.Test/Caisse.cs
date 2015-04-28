using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FruitShop.Test
{
    public class Caisse
    {
        private int _panier = 0;
        private int _qteCerise = 0;
        private int _qteBanane = 0;
        private int _qtePomme = 0;
        private int _qteApple = 0;
        private int _qteMele = 0;

        
        private int _qteFamillePomme = 0;
        
        private int _reducCerise = 20;
        private int _reducFamillePomme = 100;
        private int _reduc5Fruits = 200;

        

        internal int AddFruit(string p)
        {
            string[] fruits = p.Split(',');

            foreach (var fruit in fruits)
            {
                bool isFamillePomme = false;

                switch (fruit.Trim().ToLower())
                {
                    case "pomme":
                        isFamillePomme = true;
                        _qtePomme++;
                        _qteFamillePomme++;
                        _panier += 100;
                        break;

                    case "apple":
                        isFamillePomme = true;
                        _qteApple++;
                        _qteFamillePomme++;
                        if ((_qteApple != 0) && (_qteApple % 3 == 0))
                        {
                            // 3 pour le prix de 2
                        }
                        else
                        {
                            _panier += 100;
                        }

                        break;

                    case "mele":
                        isFamillePomme = true;
                        _qteMele++;
                        _qteFamillePomme++;
                        if ((_qteMele != 0) && (_qteMele % 2 == 0))
                        {
                            // 2 pour le prix d'1
                        }
                        else
                        {
                            _panier += 100;
                        }
                        break;
                    case "banane":

                        _qteBanane++;

                        if ((_qteBanane != 0) && (_qteBanane % 2 == 0))
                        {
                            // 2e banane offerte, merci JC.
                        }
                        else
                        {
                            _panier += 150;
                        }


                        break;
                    case "cerise":
                        _panier += 75;
                        _qteCerise++;

                        if ((_qteCerise != 0) && (_qteCerise % 2 == 0))
                        {
                            _panier = _panier - _reducCerise;
                        }

                        break;
                    default:
                        throw (new Exception("NO DEFAULT EXCEPTION"));
                }

                if (isFamillePomme)
                {
                    if ((_qteFamillePomme != 0) && (_qteFamillePomme % 4 == 0))
                    {
                        _panier = _panier - _reducFamillePomme;
                    }
                }

                var qteFruits = _qteBanane+_qteCerise+_qteFamillePomme;
                if ((qteFruits != 0) && (qteFruits % 5 == 0))
                {
                    _panier = _panier - _reduc5Fruits;
                }
            }

            return _panier;
        }
    }
}

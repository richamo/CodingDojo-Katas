using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDojo.Model
{
    public class Cashier
    {
        List<Product> _products;
        List<Promotion> _promotions;
        private string _countryCode;
        public Cashier(string countryCode)
        {
            _countryCode = countryCode;
            _promotions = new List<Promotion>();
            _products = new List<Product>();
        }

        public Cashier()
        {
            _countryCode = string.Empty;
            _promotions = new List<Promotion>();
            _products = new List<Product>();
        }
        public void AddPromotion(Promotion promotion)
        {
            _promotions.Add(promotion);
        }
        public void Add(Product product)
        {

            _products.Add(product);
        }
        public int Total()
        {
            int somme = 0;

            foreach (var item in _products)
            {
                somme += item.Price;
            }

            return somme - GetRemise();

        }

        private int GetRemise()
        {
            var somme = 0;
            foreach (var promotion in _promotions)
            {

                if (String.IsNullOrEmpty(promotion.ProductName))
                {
                    var productQuantity = _products.Count(p =>  p.CountryCode == promotion.CountryCode);
                    var t = Convert.ToInt16(productQuantity / promotion.QuantityTrigger);
                    somme += t * promotion.Remise;
                }
                else
                {
                    var productQuantity = _products.Count(p => (p.Name == promotion.ProductName) && p.CountryCode == promotion.CountryCode);
                    var t = Convert.ToInt16(productQuantity / promotion.QuantityTrigger);
                    somme += t * promotion.Remise;
                }
            }
            return somme;
        }

        public override string ToString()
        {
            return Total().ToString();
        }
    }
}

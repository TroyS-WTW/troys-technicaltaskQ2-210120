using System;

namespace TroyS.TechnicalProblemQ2
{
    public class ProductVarietyPriceChecker
    {
        public decimal ProductVarietyPriceInEuro(decimal priceInGbp)
        {
            decimal conversionRate = 1.5m;

            if (priceInGbp < 0) throw new ArgumentOutOfRangeException("Product variety price cannot be less than zero");

            var priceInEuro = priceInGbp * conversionRate;
            return priceInEuro;
        }
    }
}

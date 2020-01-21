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

        public decimal ProductVarietyPriceSum(decimal productVarietyPrice1, decimal productVarietyPrice2, decimal productVarietyPrice3, decimal productVarietyPrice4)
        {
            return (productVarietyPrice1 + productVarietyPrice2 + productVarietyPrice3 + productVarietyPrice4);
        }
    }
}

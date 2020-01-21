using System;

namespace TroyS.TechnicalProblemQ2
{
    public class ProductVarietyPriceChecker
    {
        private static string ProductVarietyPriceCannotBeLessThanZeroMessage ="Product variety price cannot be less than zero";
           
        public decimal ProductVarietyPriceInEuro(decimal priceInGbp)
        {
            decimal conversionRate = 1.5m;

            if (priceInGbp < 0) throw new ArgumentOutOfRangeException(ProductVarietyPriceCannotBeLessThanZeroMessage);

            var priceInEuro = priceInGbp * conversionRate;
            return priceInEuro;
        }

        public decimal ProductVarietyPriceSum(decimal productVarietyPrice1, decimal productVarietyPrice2, decimal productVarietyPrice3, decimal productVarietyPrice4)
        {
            const char minusChar = (char)45;

            if (productVarietyPrice1.ToString().Contains(minusChar.ToString()) ||
                productVarietyPrice2.ToString().Contains(minusChar.ToString()) ||
                productVarietyPrice3.ToString().Contains(minusChar.ToString()) ||
                productVarietyPrice4.ToString().Contains(minusChar.ToString())) throw new ArgumentOutOfRangeException(ProductVarietyPriceCannotBeLessThanZeroMessage);

            return (productVarietyPrice1 + productVarietyPrice2 + productVarietyPrice3 + productVarietyPrice4);
        }

     
    }
}

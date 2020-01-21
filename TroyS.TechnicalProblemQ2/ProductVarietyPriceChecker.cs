namespace TroyS.TechnicalProblemQ2
{
    public class ProductVarietyPriceChecker
    {
        public decimal ProductVarietyPriceInEuro(decimal priceInGbp)
        {
            decimal conversionRate = 1.5m;

            var priceInEuro = priceInGbp * conversionRate;
            return priceInEuro;
        }
    }
}

using System;
using NUnit.Framework;

namespace TroyS.TechnicalProblemQ2.UnitTests.Tests
{
    [TestFixture]
    public class ProductVarietyPriceCheckerTests
    {
        [TestCase(10, 15)]
        [TestCase(20, 30)]
        [TestCase(22, 33)]
        [TestCase(28, 42)]
        [TestCase(12, 18)]
        [TestCase(15, 22.5)]
        [TestCase(60, 90)]
        [TestCase(14, 21)]
        [TestCase(24, 36)]
        [TestCase(45, 67.5)]
        public void Product_Variety_Price_In_Euro_Is_Correct(decimal priceInGbp, decimal expectedPriceInEuro)
        {
            var productVarietyPriceChecker = new ProductVarietyPriceChecker();

            var actualPriceInEuro = productVarietyPriceChecker.ProductVarietyPriceInEuro(priceInGbp);

            NUnit.Framework.Assert.AreEqual(expectedPriceInEuro, actualPriceInEuro);
        }


        [TestCase(-1)]
        public void Negative_Product_Variety_Price_Entry_Throws_An_Exception(decimal priceInGbp)
        {
            var productVarietyPriceChecker = new ProductVarietyPriceChecker();

            Assert.That
                (() => productVarietyPriceChecker.ProductVarietyPriceInEuro(priceInGbp),
                Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(15, 30, 33, 42, 120)]
        [TestCase(18, 22.5, 90, 0, 130.5)]
        [TestCase(21, 36, 0, 0, 57)]
        [TestCase(67.5, 0, 0, 0, 67.5)]
        public void Sum_of_Product_Variety_Prices_In_Euro_Is_Correct(decimal productPrice1, decimal productPrice2, decimal productPrice3, decimal productPrice4, decimal expectedTotalPrice)
        {
            var productVarietyPriceChecker = new ProductVarietyPriceChecker();

            decimal actualProductVarietyPriceSumInEuro = productVarietyPriceChecker.ProductVarietyPriceSum(productPrice1, productPrice2, productPrice3, productPrice4);

            Assert.AreEqual(expectedTotalPrice, actualProductVarietyPriceSumInEuro);
        }

        [TestCase(-1, 30, 33, 42)]
        [TestCase(18, -1, 90, 0)]
        [TestCase(21, 36, -1, 0)]
        [TestCase(67.5, 0, 0, -1)]
        public void Sum_With_At_Least_One_Negative_Product_Variety_Price_Entry_Throws_An_Exception(decimal productPrice1, decimal productPrice2, decimal productPrice3, decimal productPrice4)
        {
            var productVarietyPriceChecker = new ProductVarietyPriceChecker();

            Assert.That
                (() => productVarietyPriceChecker.ProductVarietyPriceSum(productPrice1, productPrice2, productPrice3, productPrice4),
                Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}

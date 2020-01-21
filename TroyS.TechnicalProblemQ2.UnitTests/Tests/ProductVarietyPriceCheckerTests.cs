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
            throw new NotImplementedException();
        }



    }
}

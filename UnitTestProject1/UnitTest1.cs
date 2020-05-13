using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaulMcDonagh_S00189392;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIncreasePrice()
        {
            //ARRANGE
            Phone p1 = new Phone();
            p1.Price = 200m;
            decimal expectedPrice = 220m;
            //ACT
            p1.IncreasePrice(10);

            //ASSERT
            Assert.AreEqual(expectedPrice, p1.Price);
        }
    }
}

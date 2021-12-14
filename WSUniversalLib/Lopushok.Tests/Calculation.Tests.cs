using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace Lopushok.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getQuantityForProduct_NonExistentProductType()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(0, 1, 1, 1, 1));
        }

        [TestMethod]
        public void getQuantityForProduct_NonExistentMaterialType()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(1, 0, 1, 1, 1));
        }

        [TestMethod]
        public void getQuantityForProduct_ZeroCount()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(1, 1, 0, 1, 1));
        }

        [TestMethod]
        public void getQuantityForProduct_ZeroWidth()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(1, 1, 1, 0, 1));
        }

        [TestMethod]
        public void getQuantityForProduct_ZeroLength()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(1, 1, 1, 1, 0));
        }

        [TestMethod]
        public void getQuantityForProduct_GoodValues()
        {
            Assert.AreEqual(2, Calculation.getQuantityForProduct(1, 1, 1, 1, 1));
        }

        [TestMethod]
        public void getQuantityForProduct_NegativeWidth()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(1, 0, 1, -1, 1));
        }

        [TestMethod]
        public void getQuantityForProduct_NegativeLength()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(1, 0, 1, 1, -1));
        }

        [TestMethod]
        public void getQuantityForProduct_WrongProductType()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(12, 1, 1, 1, 1));
        }

        [TestMethod]
        public void getQuantityForProduct_WrongMaterialTypeh()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(1, 31, 1, 1, 1));
        }



        [TestMethod]
        public void hardGetQuantityForProduct_GoodFloatValues()
        {
            Assert.AreEqual(4, Calculation.getQuantityForProduct(1, 1, 1, 1.2f, 2.4f));
        }

        [TestMethod]
        public void hardGetQuantityForProduct_WrongFloatWidth()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(1, 1, 1, -4.5f, 1.4f));
        }

        [TestMethod]
        public void hardGetQuantityForProduct_WrongFloatLength()
        {
            Assert.AreEqual(-1, Calculation.getQuantityForProduct(1, 1, 1, 6.1f, -3.2f));
        }

        [TestMethod]
        public void hardGetQuantityForProduct_GoodSmallFloatValues()
        {
            Assert.AreEqual(2, Calculation.getQuantityForProduct(1, 1, 1, 1.001f, 1.01002f));
        }

        [TestMethod]
        public void HardgetQuantityForProduct_GoodBigFloatValues()
        {
            Assert.AreEqual(3018, Calculation.getQuantityForProduct(1, 1, 1, 45.41f, 60.23f));
        }
    }
}

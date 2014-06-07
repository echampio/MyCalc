using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalc;

namespace MyCalcTests
{
    ///This is a test class for CalcTest and is intended
    ///to contain all CalcTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CalcTest
    {
        /// <summary>
        ///A test for Calc Constructor
        ///</summary>
        [TestMethod()]
        public void ConstructorTest()
        {
            Calc c = new Calc();
            Assert.IsTrue(true);
        }

        /// <summary>
        ///A test for the add method.
        ///</summary>
        [TestMethod()]
        public void addTest()
        {
            Calc c = new Calc();
            Assert.AreEqual<double>(6.0D, c.add(1, 5));
        }

        /// <summary>
        /// A test for the sub method.
        /// </summary>
        [TestMethod()]
        public void subTest()
        {
            Calc c = new Calc();
            Assert.AreEqual<double>(4.0D, c.sub(5, 1));
        }
    }
}

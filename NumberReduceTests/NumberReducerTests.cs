using System;
using NumberReduce;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberReduceTests
{
    [TestClass]
    public class NumberReducerTests
    {
        [TestMethod]
        public void Test_EachDigitIncreasing()
        {
            string s = "2345";

            Assert.AreEqual((uint)234, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)23, NumberReducer.ReduceStringDigits(s, 2));
            Assert.AreEqual((uint)2, NumberReducer.ReduceStringDigits(s, 3));
        }

        [TestMethod]
        public void Test_EachDigitDecreasing()
        {
            string s = "5432";

            Assert.AreEqual((uint)432, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)32, NumberReducer.ReduceStringDigits(s, 2));
            Assert.AreEqual((uint)2, NumberReducer.ReduceStringDigits(s, 3));
        }        

        [TestMethod]
        public void Test_AllDigitsEqual()
        {
            string s = "1111";

            Assert.AreEqual((uint)111, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)11, NumberReducer.ReduceStringDigits(s, 2));
            Assert.AreEqual((uint)1, NumberReducer.ReduceStringDigits(s, 3));

            s = "9999";

            Assert.AreEqual((uint)999, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)99, NumberReducer.ReduceStringDigits(s, 2));
            Assert.AreEqual((uint)9, NumberReducer.ReduceStringDigits(s, 3));
        }

        [TestMethod]
        public void Test_EachTriadCombo()
        {
            string s = "123";
            Assert.AreEqual((uint)12, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)1, NumberReducer.ReduceStringDigits(s, 2));

            s = "132";
            Assert.AreEqual((uint)12, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)1, NumberReducer.ReduceStringDigits(s, 2));

            s = "213";
            Assert.AreEqual((uint)13, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)1, NumberReducer.ReduceStringDigits(s, 2));

            s = "231";
            Assert.AreEqual((uint)21, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)1, NumberReducer.ReduceStringDigits(s, 2));

            s = "321";
            Assert.AreEqual((uint)21, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)1, NumberReducer.ReduceStringDigits(s, 2));

            s = "312";
            Assert.AreEqual((uint)12, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)1, NumberReducer.ReduceStringDigits(s, 2));
        }

        [TestMethod]
        public void Test_SimilarSets()
        {
            string s = "9898";

            Assert.AreEqual((uint)898, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)88, NumberReducer.ReduceStringDigits(s, 2));
            Assert.AreEqual((uint)8, NumberReducer.ReduceStringDigits(s, 3));

            s = "1100";

            Assert.AreEqual((uint)100, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)0, NumberReducer.ReduceStringDigits(s, 2));
            Assert.AreEqual((uint)0, NumberReducer.ReduceStringDigits(s, 3));
        }

        [TestMethod]
        public void Test_MixedSets()
        {
            string s = "623819";

            Assert.AreEqual((uint)23819, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)2319, NumberReducer.ReduceStringDigits(s, 2));
            Assert.AreEqual((uint)219, NumberReducer.ReduceStringDigits(s, 3));
            Assert.AreEqual((uint)19, NumberReducer.ReduceStringDigits(s, 4));
            Assert.AreEqual((uint)1, NumberReducer.ReduceStringDigits(s, 5));

            s = "869843";

            Assert.AreEqual((uint)69843, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)6843, NumberReducer.ReduceStringDigits(s, 2));
            Assert.AreEqual((uint)643, NumberReducer.ReduceStringDigits(s, 3));
            Assert.AreEqual((uint)43, NumberReducer.ReduceStringDigits(s, 4));
            Assert.AreEqual((uint)3, NumberReducer.ReduceStringDigits(s, 5));

            s = "2435";

            Assert.AreEqual((uint)235, NumberReducer.ReduceStringDigits(s, 1));
            Assert.AreEqual((uint)23, NumberReducer.ReduceStringDigits(s, 2));
        }

    }
}

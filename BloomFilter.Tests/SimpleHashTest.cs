using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BloomFilter.Tests
{
    [TestClass]
    public class SimpleHashTest
    {

        /// <summary>
        /// Test to check that the Simple Hash hashes the same for each object.
        /// </summary>
        [TestMethod]
        public void HashTestPositive()
        {
            var hash = new SimpleHash();

            var testWord = "blarg";
            var testWord2 = "blarg";
            var result1 = hash.Hash(testWord);
            var result2 = hash.Hash(testWord2);

            Assert.AreEqual(result1, result2, $"{result1} and {result2} should be identical, the hash algorithm has errors.");
        }

        /// <summary>
        /// Negative test to check that the Simple Hash hashes the same for each object.
        /// </summary>
        [TestMethod]
        public void HashTestMegative()
        {
            var hash = new SimpleHash();

            var testWord = "blarg";
            var testWord2 = "blargagain";
            var result1 = hash.Hash(testWord);
            var result2 = hash.Hash(testWord2);

            Assert.AreNotEqual(result1, result2, $"{result1} and {result2} should not be identical, the hash algorithm has errors.");
        }
    }
}

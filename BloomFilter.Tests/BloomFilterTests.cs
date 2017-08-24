using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BloomFilter.Tests
{
    [TestClass]
    public class BloomFilterTests
    {
        /// <summary>
        /// A Bloom filter is a method for determining whether an item is a member of a set. It's
        ///useful for checking membership in a very large set without using excessive memory.
        /// </summary>
        [TestMethod]
        public void MainLineTest()
        {
            Assert.Inconclusive("This is the main test that should pass to indicate that the bloom filter works.");
        }

        [TestMethod]
        public void HashTest()
        {
            Assert.Inconclusive("This is the first of many hash tests to ensure hashes are unique.  This might be replaced by a tested library");
        }
    }
}

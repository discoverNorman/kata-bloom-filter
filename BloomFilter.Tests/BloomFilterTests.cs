using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BloomFilter.Tests
{
    /// <summary>
    /// A Bloom filter is a method for determining whether an item is a member of a set. It's
    ///useful for checking membership in a very large set without using excessive memory.
    /// </summary>
    [TestClass]
    public class BloomFilterTests
    {
        [TestMethod]
        public void MainLineTestCaseMatch()
        {


            BloomFilter.IHash<string, int> hash = new SimpleHash();

            BloomFilter.IBloomFilter<string,int> bloomFilter = new NormanBloomFilter(hash,1000,3);
            var testWord = "blarg";

            bloomFilter.Add(testWord);

            var result1 = bloomFilter.Seek(testWord);

            Assert.IsTrue(result1, $"{testWord} was added to the filter, and should be the only item in the filter.  Your filter/ hash is broken");
        }

        [TestMethod]
        public void MainLineTestCaseNoMatch()
        {
            Assert.Inconclusive("Not Yet Implemented");

            BloomFilter.IBloomFilter<string,int> bloomFilter = null;
            var testWord = "blarg";
            var testWord2 = "butterfly";
            
            var hash = new List<IHash<string, int>>();

            bloomFilter.Add(testWord);

            var result1 = bloomFilter.Seek(testWord);

            Assert.IsTrue(result1, $"{testWord2} was not added to the filter, and should be the only item in the filter.  Your filter/ hash is broken");
        }
        
    }
}

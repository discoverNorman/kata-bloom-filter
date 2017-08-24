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

            BloomFilter.IHash<string, int> hash = new SimpleHash();
            BloomFilter.IBloomFilter<string, int> bloomFilter = new NormanBloomFilter(hash, 1000, 3);
            var testWord = "blarg";
            var testWord2 = "blargAgain";

            bloomFilter.Add(testWord);
            bloomFilter.Add(testWord2);
            var result1 = bloomFilter.Seek(testWord);

            Assert.IsTrue(result1, $"{testWord2} was not added to the filter, and should be the only item in the filter.  Your filter/ hash is broken");
        }

        [TestMethod]
        public void End2EndTest()
        {
            var stored = new List<string>() { "the", "most", "pressing", "task", "is", "to", "teach", "people", "how", "to", "learn." };
            var notstored = new List<string>();

            BloomFilter.IHash<string, int> hash = new SimpleHash();
            BloomFilter.IBloomFilter<string, int> bloomFilter = new NormanBloomFilter(hash, 1000, 3);
         
            foreach(var word in stored)
            {
                bloomFilter.Add(word);
                notstored.Add(word.ToUpper());
            }

            foreach(var word in notstored)
            {
                Assert.IsFalse(bloomFilter.Seek(word), $"{word} was not stored,how was it found?");
            }

        }

    }
}

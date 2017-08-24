using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    /// <summary>
    /// My implementation of a Bloom Filter.
    /// </summary>
    public class NormanBloomFilter : IBloomFilter<string, int>
    {
        private bool[] _table = null;

        /// <summary>
        /// The Hash Algorithm
        /// </summary>
        public IHash<string, int> Hash { get; private set; }
        public int Offset { get; private set; }

        public NormanBloomFilter(IHash<string, int> hash, int size, int offset)
        {
            this.Hash = hash;
            this._table = new bool[size];
        }

        /// </inheritdoc>
        public void Add(string item)
        {
            foreach (var index in getIndexes(item).AsParallel())
            {
                this._table[index] = true;
            }
        }

        /// </inheritdoc>
        public bool Seek(string item)
        {
            foreach (var index in getIndexes(item).AsParallel())
            {
                if (this._table[index])
                    return this._table[index]; ;
            }
            return false;
        }
     
    
        private IEnumerable<int> getIndexes(string item)
        {
            for (int i = 0; i <= this.Offset; i++)
            {
                yield return Math.Abs(this.Hash.Hash(item + i) % this._table.Length);
            }
        }
    }
}

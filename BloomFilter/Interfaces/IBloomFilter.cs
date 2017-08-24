using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    /// <summary>
    /// The Bloom Filter Implementation
    /// </summary>
    /// <typeparam name="T">The Item Type to be Hashed</typeparam>
    /// <typeparam name="K">The Key Type of the Hash</typeparam>
    public interface IBloomFilter<T,K>
    {
        IEnumerable<IHash<T,K>> Hashes { get; }
        /// <summary>
        /// Adds an item to the Hash
        /// </summary>
        /// <param name="item">The Item to be Hashed</param>
        void Add(T item);

        /// <summary>
        /// Seeks to see if the item is in the Filter
        /// </summary>
        /// <param name="item">The Item to be Hashed</param>
        /// <returns><b>True on Match</b> False on No Match</b></returns>
        bool Seek(T item);
    }
}

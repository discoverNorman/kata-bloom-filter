using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    /// <summary>
    /// The implementation of the Hash
    /// </summary>
    /// <typeparam name="T">The item to be Hashed</typeparam>
    /// <typeparam name="K">The resulting type</typeparam>
    public interface IHash<T,K>
    {
        /// <summary>
        /// The Hash Function
        /// </summary>
        /// <param name="item">The Item to be Hashed</param>
        /// <returns>The Hash Value</returns>
        K Hash(T item);
    }
}

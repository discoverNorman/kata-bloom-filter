using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    public class SimpleHash : IHash<string, int>
    {
        public int Hash(string item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item", "item cannot be null");
            }

            return item.GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_95_150
{
    class Collections_Concurrent
    {
        /*
        System.Collections.Concurrent namespace was introduced in .NET 4 framework. It provides several threadsafe
        collections classes which protect a collection from being manipluated by multiple threads. Collection
        classes that are defined in a System.Collections.Concurrent can only be manipulated by a single thread.
        The .NET 4.0 Framework introduces several thread-safe collections in the System.Collections.Concurrent
        namespace. 
        */
        public void ConcurrentUse()
        {
            /*
             Class                  Explanation
                ConcurrentBag<T> Represents a thread-safe, unordered collection of objects.
                ConcurrentDictionary<T,V> Represents a thread-safe collection of key-value pairs.
                ConcurrentQueue<T> Represents a thread-safe First In, First Out (FIFO) collection.
                ConcurrentStack<T> Represents a thread-safe Last In, First Out (LIFO) collection.
             */
        }
    }
}

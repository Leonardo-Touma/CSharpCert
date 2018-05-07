using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_95_150
{
    /*
     IEnumerable
        IEnumerable interface is defined in System.Collections namespace.
        It helps to create a customized nongeneric
        collection. It contains a single GetEnumerator method that returns an IEnumerator.
        We’ll discuss
        IEnumerator in much detail in a later topic.
        But for now, IEnumerator is used to iterate over a collection,
        stores the information of a current index,
        its value, and whether or not a collection iteration has completed
        Foreach loop only iterate over those types which implemented IEnumerable interface,
        i.e., ArrayList and Queue.
    */
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
    class myArrayList : IEnumerable
    {
        object[] array = new object[4];
        int index = -1;
        public void Add(object o)
        {
            if (++index < array.Length)
            {
                array[index] = o;
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            myArrayList list = new myArrayList();
            //stores object data in myArraylist
            list.Add("Ali");
            list.Add(22);
            list.Add("Sundus");
            list.Add(21);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        /*
         Output
            Ali
            22
            Sundus
            21
         */
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fråga 1
            //double d = 34.5;
            //object o = d;
            //int i = (int)o;
            //Console.WriteLine(i);
            //Console.ReadKey();
        }

    }
    class Players:IList<int>
    {
        public string Name { get; set; }
        public int Coins { get; set; }
        Players players;
        public int this[int index]
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public Players()
        {
           players = new Players();
        }

        public int Count => players.Count();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(int item)
        {
            players.Add(item);
        }

        public void Clear()
        {
            players.Clear();
        }

        public bool Contains(int item)
        {
            if (players.Contains(item))
            {
                return true;
            }
            return false;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            for(int i = 0; i < players.Count(); i++)
            {
                players[i] = array[arrayIndex];
            }
            foreach (var item in array)
            {
                Console.WriteLine("Array: " + array);
            }
           
        }

        public IEnumerator<int> GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(int item)
        {
            return item;
        }

        public void Insert(int index, int item)
        {
            for (int i  = 0; i < players.Count(); i++)
            {
                var list = players[i] = index;
                list = Coins;
            }
        }

        public bool Remove(int item)
        {
            return players.Remove(item);
        }

        public void RemoveAt(int index)
        {
            // players.RemoveAt(index);
            for (int i = 0; i < players.Count(); i++)
            {
                if (players[i] == index)
                {
                    players.RemoveAt(index);
                }
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

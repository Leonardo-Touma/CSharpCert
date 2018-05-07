using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_95_150
{
    class Collections
    {
        /*
            Class           Explanation
            ArrayList: Array of objects whose size can grow and shrink dynamically
            Hashtable: Collection of key/value pair, organize on base of hash code
            Queue: Manages group of data in First In, First Out (FIFO) order
            Stack: Manages group of data in Last In, First Out (LIFO) order
        */
        public void Arraylists()
        {
            /*
         ArrayList
            Add() Add an object to the end of ArrayList
            Contains() Return true if specific object is in ArrayList
            Clone() Create a shallow copy of ArrayList
            Remove() Remove the first occurance of specific object in ArrayList
            RemoveAt() Remove the object from specific index of ArrayList
            Clear() Remove all objects from the ArrayList
            Count Get the actual number of objects stored in ArrayList
            Capacity Get or Set number of objects that ArrayList can contain
         */
            ArrayList arraylist = new ArrayList();
            //add objects in arraylist
            arraylist.Add(22);
            arraylist.Add("Ali");
            arraylist.Add(true);
            //Iterate over each index of arraylist
            for (int i = 0; i < arraylist.Count; i++)
            {
                Console.WriteLine(arraylist[i]);
            }
            arraylist.Remove(22);
            Console.WriteLine();
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
            //Output
            //for:
            //22
            //Ali
            //True
            //Foreach: 
            //Ali
            //True
        }
        public void HashtableUse()
        {
            /*
         Method        Explanation
           Add() Add an element with the specified key and value
           ContainsKey() Return true if specific key is in Hashtable
           ContainsValue Return true if specific value is in Hashtable
           Clone() Create a shallow copy of Hashtable
           Remove() Remove the element with the specified key from ArrayList
           Clear() Remove all objects from the Hashtable
           Count Get the actual number of key/value pairs in Hashtable
           Keys Get list of keys contains in Hashtable
           Values Get list of values contains in Hashtable
       */
            Hashtable owner = new Hashtable();
            //Add some values in Hashtable
            //There are no keys but value can be duplicate
            owner.Add("Bill", "Microsoft");
            owner.Add("Paul", "Microsoft");
            owner.Add("Steve", "Apple");
            owner.Add("Mark", "Facebook");
            //Display value against key
            Console.WriteLine("Bill is the owner of {0}", owner["Bill"]);
            //ContainsKey can be use to test key before inserting
            if (!owner.ContainsKey("Trump"))
            {
                owner.Add("Trump", "The Trump Organization");
            }
            // When you use foreach to enumerate hash table elements,
            // the elements are retrieved as KeyValuePair objects.
            //DictionaryEntry is the pair of key & value
            Console.WriteLine();
            foreach (DictionaryEntry item in owner)
            {
                Console.WriteLine("{0} is owner of {1}", item.Key, item.Value);
            }
            //Get All values stored in Hashtable
            var allValues = owner.Values;
            Console.WriteLine();
            foreach (var item in allValues)
            {
                Console.WriteLine("Company: {0}", item);
            }

            //Output
                //Bill is the owner of Microsoft
                //Steve is the owner of Apple
                //Trump is the owner of The Trump Organization
                //Mark is the owner of Facebook
                //Bill is the owner of Microsoft
                //Paul is the owner of Microsoft
                //Company: Apple
                //Company: The Trump Organization
                //Company: Facebook
                //Company: Microsoft
                //Company: Microsoft
        }
        public void QueueUse()
        {
            /*
             Method         Explanation
                Enqueue() Add an element to the end of the Queue
                Dequeue() Remove and return the object at the beginning of the Queue
                Peek() Return the object at the beginning of the queue without removing it
                ToArray() Copy the Queue elements to a new array
                Contains() Return true if a specified object is in the Queue
                Clear() Remove all objects from the Queue
                Clone() Create a shallow copy of the Queue
                Count Get the actual number of objects in Queue
             */
            Queue days = new Queue();
            //Add(Enque) objects in queus
            days.Enqueue("Mon");
            days.Enqueue("Tue");
            days.Enqueue("Wed");
            days.Enqueue("Thu");
            days.Enqueue("Fri");
            days.Enqueue("Sat");
            days.Enqueue("Sun");
            // Displays the properties and values of the Queue.
            Console.WriteLine("Total elements in queue are {0}", days.Count);
            //Remove and return first element of the queue
            Console.WriteLine("{0}", days.Dequeue());
            //return first element of queue without removing it from queue
            //return 'Tue'
            Console.WriteLine("{0}", days.Peek());
            //Iterate over each element of queue
            Console.WriteLine();
            foreach (var item in days)
            {
                Console.WriteLine(item);
            }
            /*
                Output
                    Total elements in queue are 7
                    Mon
                    Tue
                    Tue
                    Wed
                    Thu
                    Fri
                    Sat
                    Sun
             */
        }
        public void UseStack()
        {
            /*
             * Method       Explanation
                    Push() Insert the object at the top of the Stack
                    Pop() Remove and return object at the top of the Stack
                    Peek() Return the object at the top of the Stack without removing it
                    ToArray() Copy the Stack elements to a new array
                    Contains() Return true if a specified object is in the Stack
                    Clear() Remove all objects from the Stack
                    Clone() Create a shallow copy of the Stack
                    Count Get the actual number of objects in Stack
             */
            Stack history = new Stack();
            //Insert browser history in stack
            history.Push("google.com");
            history.Push("facebook.com/imaliasad");
            history.Push("twitter.com/imaliasad");
            history.Push("youtube.com");
            // Displays the properties and values of the Stack.
            Console.WriteLine("Total elements in stack are {0}", history.Count);
            //Remove and return top element of the Stack
            Console.WriteLine("{0}", history.Pop());
            //return top element of Stack without removing it from Stack
            //return 'twitter.com/imaliasad'
            Console.WriteLine("{0}", history.Peek());
            //Iterate over each element of Stack
            Console.WriteLine();
            foreach (var item in history)
            {
                Console.WriteLine(item);
            }
            /*
             Output
                Total elements in stack are 4
                youtube.com
                twitter.com/imaliasad
                twitter.com/imaliasad
                facebook.com/imaliasad
                google.com
             */
        }
    }
}

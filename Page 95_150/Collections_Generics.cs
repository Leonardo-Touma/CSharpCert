using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_95_150
{
    class Collections_Generics
    {
        /*
         System.Collections.Generics is a namespace which contains classes and interfaces to manage a
            strongly-typed collection. In a generic collection, data cannot be boxed/unboxed because data always
            gets type-safed. It is faster and better than classes and interfaces defined in System.Collections. It also
            defines multiple data structures to store and retrieve data such as List<T>, Queue<T>, Stack<T>, and
            Dictionary<TKey, TValue>.
         */
        /*
        Class          Explanation
       List<T> List of type-safe objects that can dynamically grow & shrink
       Dictionary<Tkey,Tvalue> Represents collection of type-safe keys and values
       Queue<T> Represents First In, First Out collection of type-safe objects
       Stack<T> Represents Last In, First Out collection of type-safe objects 
       */
        public void NormalListT()
        {
            /*
             Method         Explanation
            Add() Add an object to the end of the List<T>
            Contains() Return true if specified object is in List<T>
            Sort() Sort all the objects of List<T> by using comparer
            Remove() Remove the first occurance of specific object in List<T>
            RemoveAt() Remove the object from specified index of List<T>
            Clear() Remove all objects from the List<T>
            Find() Search the object by using specified predicate
            Count Get the actual number of objects stored in List<T>
             */
        }
        public void DictionaryListT()
        {
            /*
            Method          Explanation
            Add() Add pair of type-safe key/value in Dictionary.
            ContainsKey() Return true if specific key is in Dictionary.
            ContainsValue Return true if specific value is in Dictionary.
            Clear() Remove all objects from the Dictionary.
            Remove() Remove the element with the specified key in Dictionary.
            Count Get the actual number of key/value pairs in Dictionary.
            Keys Get list of keys contained in Dictionary.
            Values Get list of values contained in Dictionary
             */
            //Initialize Dictionary (int for roll# and assign it to student)
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            //Adding student against their roll#
            students.Add(53, new Student { Name = "Ali Asad", Age = 22 });
            students.Add(11, new Student { Name = "Sundus Naveed", Age = 21 });
            students.Add(10, new Student { Name = "Hogi", Age = 12 });
            //Display Name against key
            Console.WriteLine("Roll# 11 is: {0}", students[11].Name);
            //ContainsKey can be use to test key before inserting
            if (!students.ContainsKey(13))
            {
                students.Add(13, new Student { Name = "Lakhtey", Age = 21 });
            }
            // When you use foreach to enumerate elements of dictionary,
            // the elements are retrieved as KeyValuePairPair object.
            //KeyValuePair<TKey, TValue> is the pair of key & value for dictionary
            Console.WriteLine();
            foreach (KeyValuePair<int, Student> student in students)
            {
                Console.WriteLine("Roll#: {0} - Name: {1} - Age: {2}",
                student.Key, student.Value.Name, student.Value.Age);
            }
            //Get All values stored in Dictionary
            var allValues = students.Values;
            Console.WriteLine();
            foreach (var student in allValues)
            {
                Console.WriteLine("Name: {0} - Age: {1}",
                student.Name, student.Age);
            }
            /*
             //Output
                Roll# 11 is: Sundus Naveed
                Roll# 53 - Name: Ali Asad - Age: 22
                Roll# 11 - Name: Sundus Naveed - Age: 21
                Roll# 10 - Name: Hogi - Age: 12
                Roll# 13 - Name: Lakhtey - Age: 21
                Name: Ali Asad - Age: 22
                Name: Sundus Naveed - Age: 21
                Name: Hogi - Age: 12
                Name: Lakhtey - Age: 21
             */
        }
        public void queueUseT()
        {
            /*
             Method and Property Explanation
                Enqueue() Add an element to the end of the Queue<T>.
                Dequeue() Remove and return an element at the beginning of the Queue<T>.
                Peek() Return an element at the beginning of the Queue<T> without removing it.
                ToArray() Copies the Queue<T> elements to a new array.
                Contains() Return true if a specified element is in the Queue<T>.
                Clear() Remove all elements from the Queue<T>.
                Count Get the actual number of objects in Queue.
             */
            Queue<string> days = new Queue<string>();
            //Add(Enque) string object in days
            days.Enqueue("Mon");
            days.Enqueue("Tue");
            days.Enqueue("Wed");
            days.Enqueue("Thu");
            days.Enqueue("Fri");
            days.Enqueue("Sat");
            days.Enqueue("Sun");
            // Displays the properties and values of the Queue.
            Console.WriteLine("Total elements in queue<string> are {0}",
            days.Count);
            //Remove and return first element of the queue<string>
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
                Total elements in queue<string> are 7
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
        public void stackUseT()
        {
            /*
            Method and Property Explanation
                Push() Insert the element at the top of the Stack<T>.
                Pop() Remove and return element at the top of the Stack<T>.
                Peek() Return the element at the top of the Stack<T> without removing it.
                ToArray() Copy the Stack<T> elements to a new array.
                Contains() Return true if a specified element is in the Stack<T>.
                Clear() Remove all elements from the Stack<T>.
                Count Get the actual number of elements in Stack<T>.
             */
            Stack<string> history = new Stack<string>();
            //Insert browser history in stack<string>
            history.Push("google.com");
            history.Push("facebook.com/imaliasad");
            history.Push("twitter.com/imaliasad");
            history.Push("youtube.com");
            // Displays the properties and values of the Stack<string>.
            Console.WriteLine("Total elements in stack<string> are {0}",
            history.Count);
            //Remove and return top element of the Stack<string>
            Console.WriteLine("{0}", history.Pop());
            //return top element of Stack<string> without removing it from Stack
            //return 'twitter.com/imaliasad'
            Console.WriteLine("{0}", history.Peek());
            //Iterate over each element of Stack<string>
            Console.WriteLine();
            foreach (var item in history)
            {
                Console.WriteLine(item);
            }
            /*
                Output
                Total elements in stack<string> are 4
                youtube.com
                twitter.com/imaliasad
                twitter.com/imaliasad
                facebook.com/imaliasad
                google.com
             */
        }
    }
    partial class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

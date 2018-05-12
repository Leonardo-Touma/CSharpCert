using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_95_150
{
    class IEnumeratorTValueAndNoneTValue
    {
        /*
         IEnumerator & IEnumerator<T>
            .NET defined two base class libraries. There are non-generic and generic IEnumerator interfaces to define
            the iteration of a collection.
            IEnumerator
            IEnumerator is non-generic interface defined in System.Collections namespace. It has methods and
            properties that a collection implements to define its iteration.
         */
    }
    public interface IEnumerator
    {
        //Gets value of current index of collection
        object Current { get; }
        //Move to the next index of the collection
        bool MoveNext();
        //Move to the initial position of index = -1
        void Reset();
    }
    
    class People : IEnumerable
    {
        Persons[] people;
        int index = -1;

        public void Add(Persons per)
        {
            if (++index < people.Length)
            {
                people[index] = per;
            }
        }
        public People(int size)
        {
            people = new Persons[size];
        }
        public IEnumerator GetEnumerator()
        {
            return new PersonEnum(people);
        }
    }
    //Implement IEnumerator
    public class PersonEnum : IEnumerator
    {
        Persons[] _people;
        int index = -1;
        public PersonEnum(Persons[] people)
        {
            _people = people;
        }
        //Check whether foreach can move to next iteration or not
        public bool MoveNext()
        {
            return (++index < _people.Length);
        }
        //Reset the iteration
        public void Reset()
        {
            index = -1;
        }
        //Get current value
        public object Current
        {
            get
            {
                return _people[index];
            }
        }
        class Persons
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        class Program
        {
            static void Main(string[] args)
            {
                People people = new People(3);
                people.Add(new Persons { Name = "Ali", Age = 22 });
                people.Add(new Persons { Name = "Sundus", Age = 21 });
                people.Add(new Persons { Name = "Hogi", Age = 12 });
                foreach (var item in people)
                {
                    //Cast from object to Person
                    Persons person = (Persons)item;
                    Console.WriteLine("Name:{0} Age:{1}", person.Name, person.Age);
                }
            }
        }
    }
}

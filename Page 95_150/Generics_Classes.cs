using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_95_150
{
   /*
    

    */
    partial class Person
    {
        //TODO
    }
    partial class Student : Person
    {
        //
    }
    class GenericClass<T, U> where T : U
    {
        //TODO
    }
    class RunGenericsU
    {
        //Here 'T' and 'U' types are same
        GenericClass<Person, Person> genPP =
        new GenericClass<Person, Person>();
        //Here 'T' inherit 'U' type
        GenericClass<Student, Person> genSP =
        new GenericClass<Student, Person>();
    }
    /*
     RunGenericsInterface
     */
    partial class Person : IPerson
    {
        //Implement Iperson
    }

     interface IPerson
    {
    }

    partial class Student : Person
    {
        //TODO:
    }
    class GenericClass<T> where T : IPerson
    {
        //TODO:
    }
    class RunGenericsInterface
    {
        //Here 'T' is IPerson
        GenericClass<IPerson> genIPer = new GenericClass<IPerson>();
        //Here 'T' is Person which has implement 'IPerson'
        GenericClass<Person> genPer = new GenericClass<Person>();
        //Here 'T' is Student it inherit 'Person' which implement 'IP
    }
    class Generics_Classes<T>
    {
        /*
         Kind of Constraints
            There are 6 kinds of constraints that we can apply on generic type parameters. The following table
            (Table 4-1) lists the kinds of constraints.
                Constraints            Explanation
                where T : struct Type “T” must be a value type
                where T : class Type “T” must be a reference type
                where T : new() Type “T” must has a definition of public default constructor
                where T : U Type “T” must be or child of type “U”
                where T : interfaceName Type “T” must be or implement a specified interface
         */
        /*
         Generics
         type 'T' will define at the instantiation of GenericClass
         */
        partial class Person
        {
        }
        partial class Student : Person
        {
        }
        class GenericClasss<T> where T : Person
        {
            //TODO:
        }
        class Run
        {
            public void runGenericsConversion()
            {
                Generics_Classes<Person> genPer = new Generics_Classes<Person>();
                //Student is also a Person. This is also valid.
                Generics_Classes<Student> genStd = new Generics_Classes<Student>();
            }
        }
        private T genericField;
        public T GenericMethod(T genericParameter)
        {
            this.genericField = genericParameter;
            return this.genericField;
        }


        /*KONVERTERAR T GENERIC TILL STRING OCH RETURNERAR DETTA.*/
        public string GenericProperty { get; set; }
        internal T GenericMethodAsReturned(T v)
        {
            return v;
        }
        public void returnTasString()
        {
            //Here <T> type become string
            Generics_Classes<string> genStr = new Generics_Classes<string>();
            string strData = genStr.GenericMethodAsReturned("C#");
            genStr.GenericProperty = "Certification Exam: ";
            Console.WriteLine("{0} ---- {1}", strData, genStr.GenericProperty);
            Console.ReadKey();
        }
        /*KONVERTERAR T GENERIC TILL INT OCH RETURNERAR DETTA.*/
        public int GenericPropertyWillBeConvertedToIntFromT { get; set; }
        internal T GenericMethodAsReturnedFromTToInt(T v)
        {
            return v;
        }
        public void returnTasInt()
        {
            Generics_Classes<int> genInt = new Generics_Classes<int>();
            int intData = genInt.GenericMethodAsReturnedFromTToInt(70);
            genInt.GenericPropertyWillBeConvertedToIntFromT = 483;
            Console.WriteLine("{0} - {1}", intData, genInt.GenericProperty);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_95_150
{
    class Example
    {
        public void GenericMethodArgs<T>(T first)
        {
            Console.WriteLine(first);
        }
        public T ReturnFromGenericMethodArgs<T>(T first)
        {
            return first;
        }
        public void MultipleGenericMethodArgs<T, U>(T first, U second)
        {
            Console.WriteLine("{0}: {1}", first, second);
        }
        public U ReturnFromMultipleGenericMethodArgs<T, U>(T first)
        {
            U temp = default(U);
            
            return temp;
        }
    }
    class runMethodsGenMeths
    {
        public void run()
        {
            Example ex = new Example();
            //Call generic method which has single generic type
            ex.GenericMethodArgs<int>(10);
            int FromSingle = ex.ReturnFromGenericMethodArgs<int>(10);
            Console.WriteLine(FromSingle + "\n");
            //Call generic method which has multiple generic type
            ex.MultipleGenericMethodArgs<string, int>("Exam", 70483);
            int FromMultiple =
            ex.ReturnFromMultipleGenericMethodArgs<string, int>("Exam: ");
            Console.WriteLine(FromMultiple);
        }
    }

    class Generics_Methods
    {
        public void run()
        {

        }
    }
}

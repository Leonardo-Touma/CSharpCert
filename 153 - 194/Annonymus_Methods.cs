using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153___174
{
    /*
     Anonymous Method


        An anonymous method is a method without a name. These are methods that are defined with a delegate
        keyword. An anonymous method doesn’t have a return type in its signature. Its return type depends on the
        type of delegate variable which holds its reference.
        Syntax
        delegate_type delegate_variable = delegate (parameter_list)
        {
         //Method Body
        };   
     */
    /*
     //Anonymous method that doesn't return value
           Action act = delegate ()
           {
               Console.WriteLine("Inside Anonymous method");
           };
      //Anonymous method that does return value
           Func<int, int> func = delegate (int num)
           {
               Console.Write("Inside Func: ");
               return (num * 2);
           };
           act();
           Console.WriteLine(func(4));
           Console.ReadKey(); 


        //Output
            Inside Anonymous method
            Inside Func: 8
    */
    class Annonymus_Methods
    {
    }
}

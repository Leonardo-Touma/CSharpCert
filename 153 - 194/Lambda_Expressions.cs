using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153___174
{
    /*
     Lambda Expression
        Lambda expression is a better version of implementing the anonymous method.
        Syntax
        delegate_type delegate_variable = (parameter_list) =>
        {
         //Method Body
        };
         
      //Lambda Expression that doesn't return value
            Action act = () =>
            {
                Console.WriteLine("Inside Lambda Expression");
            };
     //Lambda Expression that does have return value
            Func<int, int> func = (int num) =>
            {
                Console.Write("Inside Func: ");
                return (num * 2);
            };
            act();
            Console.WriteLine(func(4));


        //Output
            Inside Anonymous method
            Inside Func: 8
      */
    class Lambda_Expressions
    {
        public void Lambda_Expressions_That_does_not_return()
        {
            //type of name will be string
             Action<string> actName = (name) => Console.WriteLine(name);
            Action<string> actName2 = name => Console.WriteLine(name);
            actName("Ali");
            actName2("Ali");

        }
        public void Lambda_Expressions_That_Returns()
        {
            //type of name will be string
            Func<int, int> mul = (x) => x * 2;
            Console.WriteLine(mul(10));
        }
        /*
         Output
            Ali
            Ali
            20
         */
    }
}

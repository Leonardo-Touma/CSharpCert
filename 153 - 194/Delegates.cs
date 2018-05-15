using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153___174
{
    /*
     
         
    COMMON USES OF DELEGATES     
         
         
    */
    /*
     Common Built-in Delegates
        C# provides many built-in delegates that are useful for common purposes. These built-in types provide a
        shorthand notation that virtually eliminates the need to declare delegate types.
        Some common built-in delegates are:
        •	 Action
         Action
                Action is a built-in delegate type available in System namespace. It can be used with methods that don’t
                return a value and have no parameter list.
        •	 Action<>
        Action<> is a generic delegate. It can be used with methods that at least have one argument and don’t return
            a value. Action<> delegate comes with 16 generic overloads, which means it can take up to 16 arguments of
            void method.
        Action<> delegate is type-safe, which means it can take arguments of any type and
                the argument type will be type-safe at compile time.
        •	 Func<>
                //return string value
                     Func<string> info = Name;
                     Console.WriteLine(info());
                     //return string, and take string as parameter
                     Func<string, string> dynamicInfo = DynamicName;
                     Console.WriteLine(dynamicInfo("Hamza Ali"));
                     //return int, and take two int as parameter
                     Func<int, int, int> calculate = Add;
                     calculate += Min;
                     calculate += Mul;
                     foreach (Func<int, int, int> item in calculate.GetInvocationList())
                     {
                     Console.WriteLine(item(10,5));
                     }
                    My name is = Ali Asad
                    My name is = Hamza Ali
                    10 + 5 = 15
                    10 - 5 = 10
                    10 * 5 = 50
        •	 Predicate<>
        A predicate delegate represents a method that takes one input parameter and returns a bool value on the
        basis of some criteria
         
         
     */
    /*
     How to use a string delegate:
      class Program
    {
        public delegate string nameofdelegate(string msg);
        public static string display(string msg)
        {
            return msg;
        }
        static void Main(string[] args)
        {
            nameofdelegate del = new nameofdelegate(display);
            Console.WriteLine(del("hej"));
            Console.ReadKey();
        }
    }
     */
    /*
    Using delegate with mulitple methods
     public delegate void delegateName(string msg);
       class MyClass
       {
           // Declare a method with the same signature as the delegate.
           static void display(string msg)
           {
               Console.WriteLine("display: {0}", msg);
           }
           static void show(string msg)
           {
               Console.WriteLine("show: {0}", msg);
           }
           static void screen(string msg)
           {
               Console.WriteLine("screen: {0}", msg);
           }
           static void Main(string[] args)
           {
               delegateName del = display;
               //Multicast delegate
               del += show;
               del += screen;
               //calling delegate
               del("Ali");
           }
       }
       //Output
       //        display: Ali
       //        show: Ali
       //        screen: Ali
       //•	 del += a
    */
    class Delegates
    {
    }
}

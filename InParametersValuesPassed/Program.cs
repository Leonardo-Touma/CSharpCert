using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InParametersValuesPassed
{
    class Program
    {
        //Dont need to pass in a value to talk method, it takes the default and uses that.
        //If i need i can change it in Main while calling the method.
        static void Main(string[] args)
        {
            talk(2);
            //Check the definitions of the methods below i can explicitly define my inparameters with the : key
            talk(2,sit: true);
            talk(2, talking: "hej");
            Console.ReadLine();
        }
        public static void talk(string talking = "hello everything good with you?")
        {
        }
        public static void talk(int times, string talking = "hello everything good with you?", bool sit = true)
        {
        }
    }
}

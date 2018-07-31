using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDataTypeOf
{
    public class dog
    {
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new dog();
            t1.name = "hej";
            Type t2 = typeof(dog);
            //same as above but with generics and no explicit conversion
            Console.WriteLine(@"Type: {0}", t2.FullName);
            Console.WriteLine(@"Name of direct type: {0}", t2.Name);
            Console.WriteLine(
                @"Check if the class dog is public or not: {0}",
                t2.IsPublic);

            var genereicDog = Activator.CreateInstance<dog>();
            genereicDog.name = "hej";
            Console.WriteLine(genereicDog.name);
            Console.Read();
        }
    }
}

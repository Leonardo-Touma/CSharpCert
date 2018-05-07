using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCertificate
{
    class StaticConstructurs_Helper_Metods
    {
        static class staticConstructors
        {
            public static int age;
            static staticConstructors()
            {
                age = 22;
            }
        }
        static class Helper
        {
            /*
                 Unlike normal classes, static classes cannot be instantiated.
                 They're useful to define helper static methods.
                Static class doesn’t have any instance member. All members must be static in static class. Therefore,
                members of static classes can access by using the class name itself.
                Static class is defined by writing a static keyword before the class definition
             */
            /*
             To access MyMethod() from another class use following code:
                Helper.MyMethod();
             */
            public static void MyMethod()
            {
                Helper.MyMethod();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCertificate
{
    static class ExstensionClass
    {
        public static class ExtensionClass
        {
            /*
             age is an integer variable; it is called the isLessThan extension method. Remember, isLessThan is not
                defined by a .NET framework for integers. Its functionality is added by using the extension method.
                Value “30” is passed on the isLessThan parameter as compareValue, whereas this int origin refers to
                the variable age itself.
             */

        }
        public static bool IsLessThan(this int origin, int compareValue)
        {
            /*
            MAIN: 
           int age = 22;
           bool check = age.isLessThan(30);
           Console.WriteLine(check);
            */
            //return true if origin value is less
            if (origin < compareValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

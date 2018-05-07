using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCertificate
{
    class IsAsOperators
    {
        public void IsOperator()
        {
            /*
                 It’s a keyword that is used to match a type.
                 If a type matches it returns true; otherwise it returns false. A
                common use of is keyword comes with (type) explicit type conversion.
                (type)value is used to convert a type explicitly. If a type converts succesfully, it returns a value in that
                type. If a type doesn’t convert properly, it throws an exception. To avoid this exception, it is common to
                check the type inside the sandbox of is operator
             */
            /*
             int a = 2;
             if (a is s)
               {
               }
            */
            //------------------------------------------------------------
            /*
             class A {...}
                class B : A {...}
                A a = new B();
                if(a is B)
                {
                 //convert explicitly from type A to B
                 B b = (B)a;
                }
             */
        }
        public void ASOperator()
        {
            /*
            as is a keyword used to explicitly convert one type to another.
            If a type converts successfully, it would return
            value in that type. If a type doesn’t convert properly, it returns null value.
            */
            //    class A {...}
            //class B : A {...}
            //A a = new B();

            //convert explicitly from type A to B

            //B b = a as B;
        }
    }
}

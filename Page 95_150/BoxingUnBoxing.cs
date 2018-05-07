using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_95_150
{
    class BoxingUnBoxing
    {
        /*
         GENERAL BOXING AND UNBOXING
            ArrayList (ArrayList stores everything as a collection of objects). When a value is boxed, a new instance
            must be created in heap. This could take up to 20 times longer than a simple reference assignment. When a
            boxed value is unboxed, it takes 4 times longer than a simple reference assignment. 
         */
        /*
         Unboxing
            Unboxing refers to an explicit conversion of object type to non-nullable-value type or the conversion of an
            interface type to a non-nullable-value type, e.g., IComparable<int> to int. Further, the conversion of nullable
            type to the underlying value type is also known as unboxing.
            During unboxing, boxed value is unboxed from the managed heap to a value type which is being
            allocated on a Stack.
         */
        public void UnboxingAndBoxing()
        {
            int age = 22;
            object boxedAge = age; //Boxing
            int unboxedAge = (int)boxedAge;//Unboxing
        }
        /*BOXING
            the integer value age is boxed and assigned to object boxedAge.*/
        public void boxedInt()
        {
            int age = 22;
            object boxedAge = age;
        }
    }
}

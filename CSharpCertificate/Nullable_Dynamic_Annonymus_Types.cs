using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCertificate
{
    class Nullable_Dynamic_Annonymus_Types
    {
        public void NullableTypes()
        {
            bool? variableName = null;
            int? variableName1 = null;
            long? variableName2 = null;
            double? variableName3 = null;
            variableName = true;
            variableName1 = 1;
            variableName2 = 2;
            variableName3 = 2.32211;
        }
        public static void DynamicType()
        {
            /*
           Unlike implicit type (var keyword), dynamic type can store values of different types with the same
           dynamic variable. Therefore, a dynamic variable can change its type at runtime. 
           */

            /*
             •	 Dynamic type can be used for field, property, indexer, method parameter, and return
                    type.
              •	 Exception is thrown at runtime if data type or member name is not compatible.
             */
            //-------------------------------------------------
            /*
            Output
            System.Int32
            System.String
            */
            dynamic name = "Ali";
            Console.WriteLine(name.GetType());

            dynamic price = 20;
            Console.WriteLine(price.GetType());

            /*Change dynamic variable’s type at runtime*/
            dynamic i = "Ali";
            Console.WriteLine(i.GetType());
            i = 22;
            Console.WriteLine(i.GetType());
        }
        public void annonymusType()
        {
            /*
            Remarks:
           •	 In anonymous type, property value cannot be null.
           •	 Anonymous type doesn’t have method definition.
           •	 Anonymous types are class type.
           •	 Anonymous type cannot be used as method’s parameter of return type.
           •	 Anonymous type is useful to store query result from collection. 
           */
            var person = new { Name = "", Age = 22.2 };
        }
    }
}

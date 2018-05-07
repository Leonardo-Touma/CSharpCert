using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCertificate
{
    class Explicit_Implicit_Convertsion
    {
        //Explicit User Defined Conversion
        class Person
        {
            /*
            Person per = new Person { Age = 22, Name = "Ali" };
            string name = (string)per;
            Console.WriteLine(name);

            //where (string)per; casts a person’s data into “string” explicitly by returning Name of person.

            Output
            Ali
            */
            public int Age { get; set; }
            public string Name { get; set; }
            public static explicit operator string(Person per)
            {
                return per.Name;
            }
        }
        /* implicit type conversion definition*/
        class Byte
        {
            /*
             Main: 
             Byte b = new Byte();
             int totalBits = b;
             Console.WriteLine(totalBits);
             */
            public int bits = 8;
            public static implicit operator int(Byte b)
            {
                return b.bits;
            }
        }
        class Implicit_User_Defined_Conversion
        {
            //          •	 returnType tells which type of data would get returned in implicit conversion.
            //          •	 type t tells which type would get convert implicitly.
            /*
             A user can define an implicit conversion definition in a type that helps to convert it into another type.
                Implicit conversion occurs automatically.
                For implicit conversion, a special static method is defined with an implicit and operator keyword
                inside the type definition.
             */
            //public static implicit operator returnType(type t)
            //{
            //    return;
            //}
        }
    }
}

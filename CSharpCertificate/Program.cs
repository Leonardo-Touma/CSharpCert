using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page1_59
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
    public static class ExtensionClass
    {
        /*
         age is an integer variable; it is called the isLessThan extension method. Remember, isLessThan is not
            defined by a .NET framework for integers. Its functionality is added by using the extension method.
            Value “30” is passed on the isLessThan parameter as compareValue, whereas this int origin refers to
            the variable age itself.
         */
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
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Summary 
        •	 Enum constant’s values can override with integer value.
        •	 Struct constructor must initialize all data members.
        •	 Default value of reference type is always Null.
        •	 Types defined with struct and enum are examples of value types.
        •	 Types defined with class, interface, and delegates are examples of reference type.
        •	 System.Object type is base class of all types in C# hierarchy.
        •	 Anonymous types must have one or more read only properties.
        •	 Dynamic types are useful for interacting with COM, DOM and Dynamic APIs.
        •	 Value type can store null when it is declared as nullable “?”.
             */
           
            Console.ReadKey();
        }



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

        
        public void QuestionMarkOperator()
        {
            /*
         •	 Nullable<T> is an alternative of “?” operator. The above example can be written as
                Nullable<bool> isMarried = null;
         •	 Value type is boxed whenever it becomes nullable.
            */
            bool? isMarried = null;
            bool married = isMarried ?? false;
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

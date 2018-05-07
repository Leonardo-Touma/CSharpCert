using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page59_89
{
    class OverLoading
    {
        /*
     Operator Overloading
        In C#, we can overload the definition of an operator for custom types (class, struct). To overload the
        definition of an operator, we define special methods inside a custom type. These methods help the compiler
        to distinguish among different meanings of an operator that produce different results for a different type.
        Generally, in C# we can overload three kinds of operators:
        1. Unary Operators
        2. Binary Operators
        3. Comparison Operators

    Overload Unary Operators
        Unary operator operates on a single operand (+, -, !, ++, --, true, false). These are unary operators which can
        be overloaded in C#.
        Syntax
        public static return_type operator ++/-- (Type t)
        {
         // TODO:
        }
        •	 Static operator overloaded method must be static.
        •	 operator is a keyword used to define an operator overloaded method.
        •	 op use special operator symbol, describe which operator definition is going to be
        overloaded, i.e., ( +, -, ..).
        •	 Type where type must be struct or class.

        public static Distance operator ++ (Distance dis )
         {
         dis.meter += 1;
         return dis;
         }

    Overload Binary Operator
        Binary operator operates on two operands (+, -, *, /, %, &, |, ^, <<, >>). These are Binary operators which can
        be overloaded in C#.
        Syntax
        public static return_type operator op (Type1 t1, Type2 t2)
        {
         //TODO:
        }

        public static Student operator + (Student s1, Student s2)
         {
         Student std = new Student();
         std.Marks = s1.Marks + s2.Marks;
         return std;
         }

    Overload Comparison Operator
        Comparison operator operates on two operands and returns Boolean value when it compares left-sided
        operand’s value with right-sided operand’s value (==, !=, <, >, <=, >=). These are comparison operators which
        can be overloaded in C#.
        Syntax
        public static bool operator op (Type1 t1, Type2 t2)
        {
         //TODO:
        }

    public static bool operator < (Distance d1, Distance d2 )
         {
         return (d1.meter < d2.meter);
         }

    ■ Note Always overload opposite operator of comparison operator. For example, whenever we overload less
        than operator we must overload greater than operator as well. The same applies to ==, != operator.
     */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page59_89
{
    /*
     1. public abstract void Run(); declare abstract method without implementing its
        definition.
     2. public override void Run(); override the definition of Run method in derived
        class “Bike”. Thus, when Run() method is called, the always derived method will
        invoke.  
     */
    abstract class Vehicle
    {
        public abstract void Run();
    }
    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Run Bike");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vc = new Car();
            vc.Run();
        }
    }
    /*
     Interface
    Interface cannot be instantiated. Its members have no implementation detail. All implementation detail is
    defined by classes which implement (inherit) interfaces. Interface provides the highest level of abstraction.
    Key Points
    1. Do not use access specifiers with interface’s members.
    2. Do not define definition of interface members.
    3. Auto-property, indexer, method, and event can be used as a member of an
    interface.
    4. Class must implement full definition of interface’s members. Otherwise error
    may occur at compile/run time.
    5. Class can implement more than one interface.
     */
    /*
     Implement interface implicitly
     MAIN:
     IVehicle vehicle = new Bike();
     Console.WriteLine(vehicle.Wheels);
         */
    interface IVehicle
    {
        int Wheels { get; }
    }
    class Bike : IVehicle
    {
        private int wheels;
        public int Wheels
        {
            get
            {
                return wheels;
            }
        }
    }

    /*
        Implement interface explicitly
     Main: 
            Student std = new Student();
            int english = ((IEnglish)std).Marks;
            int math = ((IMath)std).Marks;
            Console.WriteLine("English Marks = {0} Math Marks = {1}",
            english, math);
     OUTPUT:
     English Marks = 9 Math Marks = 10

     Explanation
        1. IMath.Marks used to implement interface explicitly by defining name of writing
        name of interface before member name.
        2. No Access specifier used to implement explicit interfaces.
        3. ((IEnglish)std).Marks; used to access “Marks” property of “IEnglish” interface.
    
    */
    interface IEnglish
    {
        int Marks { get; }
    }
    interface IMath
    {
        int Marks { get; }
    }
    class Student : IEnglish, IMath
    {
        int english = 10;
        int math = 9;
        int IMath.Marks
        {
            get
            {
                return english;
            }
        }
        int IEnglish.Marks
        {
            get
            {
                return math;
            }
        }
    }
    /*
    MAIN: Child child = new Child();
    OUTPUT:

    Grand Parent
    Parent
    Child
    class GrandParent
    {
        public GrandParent()
        {
            Console.WriteLine("Grand Parent");
        }
    }
    class Parent : GrandParent
    {
        public Parent()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child");
        }
    }
    */
    class Program1
    {
        static void Main(string[] args)
        {
            /*
             Summary
            •	 C# has five access specifiers, i.e., Public, Private, Protected, Internal, Internal
            Protected.
            •	 Properties and Indexers both are used to encapsulate data.
            •	 Derived class can inherit all data from its base class, except one which is mentioned
            with private access specifier.
            •	 C# doesn’t allow multiple inheritance, but it allows multi-level inheritance.
            •	 A class must implement all members of an interface and all abstract methods of an
            abstract class.
            •	 Abstract method can only be written inside of an abstract class.
             */
            Console.ReadKey();
        }
    }
    /*
     Encapsulation
    Encapsulation is one of the three fundamental pillars of an object oriented program, which says, when data
    (attributes) and methods (behaviors) are defined in a single entity, it is called Encapsulation. It also refers to
    an object-oriented design principle called Data Hiding, which restricts the accessibility of data (attribute)
    and method (behavior) of an entity that are not necessary to its user.
    Encapsulation is implemented through two ways:
    1. Access Specifiers
    2. Data Protection
    Access Specifiers
    Access specifiers are special keywords, used to define the accessibility level of a type (class, struct, enum)
    and all of the data members and methods defined inside it.
    In C#, we have five kinds of access specifiers. Each access specifier defines a unique accessibility level.
    These access specifiers are:
    1. Public
    2. Private
    3. Protected
    4. Internal
    5. Protected Internal
     */
    /*
      Abstract Class
        Abstract classes cannot be instantiated.
        It is used as base class, where it provides common members to all
        its derived classes. It is either overridden partially or not at all.
        It is also used to declare abstract methods
        (method without definition) that when it inherits, it must be overridden by its derived classes.
    */

    /*
     Polymorphism
        Polymorphism is all about changing behaviors; in other words, it is different forms of one object.
        In C#, polymorphism is of two types:
        1. Static Polymorphism
        2. Dynamic Polymorphism
        Static Polymorphism
        Polymorphism in programming is all about changing behavior. While static polymorphism means changing
        behavior of methods at compile time, it is also known as early binding.
        In C#, static polymorphism can be implemented with two ways:
        1. Method Overloading
        2. Operator Overloading
     */
    /*
    Dynamic Polymorphism
        Polymorphism in programming is all about changing behavior, while dynamic polymorphism means
        changing behavior of an object at runtime by overriding the definition of a method. It is also known as late
        binding.
        In C#, method is overridden by two ways:
        1. Virtual method
        2. Abstract method 

    Virtual Method
        Virtual is a keyword used with method in base class to define a virtual method. Virtual method has a
        definition of its method; its derived class can inherit or override its definition. Thus, when calling the
        method name the runtime will determine which method to invoke.
        Syntax
        virtual return_type methodName()
        {
         //TODO:
        }

    Explanation
        1. public virtual void Run(){..} define a virtual method in base class.
        2. public override void Run(){..} override Run method in derived class by defining
        its own implementation of Run() method.
        3. Vehicle vc = new Bike(); vc holds object of its child class “Bike”.
        4. vc.Run(); control will first move to base “Run” method. When runtime is
        encountered, it’s a virtual method; it will then move to its derived class “Bike”
        definition to find implementation of “Run()” method. If it finds the method it will
        invoke it; otherwise it will come back to base class to run virtual Run() method.
    */

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

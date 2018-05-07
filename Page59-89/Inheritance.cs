using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page59_89
{
    class Inheritance
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
        class Run
        {
            public void runMethod()
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
    }
}

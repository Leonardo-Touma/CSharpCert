using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page59_89
{
    class Polymorphism
    {

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
    }
}

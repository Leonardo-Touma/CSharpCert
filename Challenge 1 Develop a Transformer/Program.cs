using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_Develop_a_Transformer
{
    enum landscape
    {
        air = 0,
        road = 1,
        water = 2
    }
    class Jet : Vehicle
    {
        public landscape Type { get; set; }
        public override void Run()
        {
            Console.WriteLine("Flying");
        }
    }
    class Car : Vehicle
    {
        public landscape Type { get; set; }
        public override void Run()
        {
            Console.WriteLine("Driving");
        }
    }
    class Boat : Vehicle
    {
        public landscape Type  { get; set; }

        public override void Run()
        {
            Console.WriteLine("Sailing");
        }
    }
    abstract class Vehicle
    {
        public int Wheels { get; set; }
        public int MaxSpeed { get; set; }
        public abstract void Run();
    }
    class Program
    {
        static void Main(string[] args)
        {
            var boat2 = new Boat()
            {
                Type = landscape.water
            };
            var car2 = new Car()
            {
                Type = landscape.water
            };
            var jet2 = new Jet()
            {
                Type = landscape.water
            };

            if (boat2.Type == landscape.water)
            {
                Vehicle boat = new Boat() { Wheels = 0, MaxSpeed = 200 };
                boat.Run();
            }
           if (car2.Type == landscape.road)
            {
                Vehicle car = new Car() { Wheels = 4, MaxSpeed = 350 };
                car.Run();
            }
           if (jet2.Type == landscape.air)
            {
                Vehicle jet = new Jet() { Wheels = 8, MaxSpeed = 900 };
                jet.Run();
            }
        }
    }
}

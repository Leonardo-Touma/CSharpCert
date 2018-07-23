using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructViewModel
{
    class Program
    {
        static void Main(string[] args)
        {
            student stud = new student();
            Console.WriteLine($"Name: {stud.binder()}");
            Console.Read();
        }
    }
    class student
    {
        public PersonViewmodel person { get; set; }
        public student()
        {
            person = new PersonViewmodel();
        }
        public string Name { get; set; } = "hej";
        public string binder()
        {
            Name += person.Name;
            return Name;
        }
    }
    struct PersonViewmodel
    {
        public string Name { get; set; }
    }
}

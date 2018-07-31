using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchEnum
{
    enum dogs
    {
        snoopy, lassie, börje
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dog = dogs.börje;
            switch (dog)
            {
                case dogs.snoopy:
                case dogs.lassie:
                    break;
                case dogs.börje:
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

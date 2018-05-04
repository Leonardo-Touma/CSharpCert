using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceQuestion
{
    class Player
    {
        public void Play()
        {
            Console.WriteLine("Icricketplayer");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            ((ICricket)player).Play();            Console.ReadKey();
        }
    }
}

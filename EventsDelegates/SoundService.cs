using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
    public class SoundService
    {
        public void OnvideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("SoundService: Sending a sound...");
        }
    }
}

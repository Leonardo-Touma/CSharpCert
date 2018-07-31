using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsDelegates
{
    public class OwnTestOfDelegatesAndEvents
    {
       
        public void Start()
        {
            var sound = new Sound() { Id = Guid.NewGuid(), Title = "eminems newest song" };

            var soundService = new soundServices();

            var soundencoder = new SoundEncoder();


            soundencoder.soundEncoded += soundService.OnSoundEncoder;
            soundencoder.encode(sound);
        }
    }
    public class Sound
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
    public class soundServices
    {
        public void OnSoundEncoder(object source, EventArgs e)
        {
            Console.WriteLine("SoundService: sound encoded...");
        }
    }
    
    public class SoundEncoder
    {
        //1. define delegate
        //2. Publish to event
        //3. Subscribe to event
        public delegate void soundEventHandler(object source, EventArgs args);

        public event soundEventHandler soundEncoded;

        public void encode(Sound sound)
        {
            Console.WriteLine("Encoding sound...");
            Thread.Sleep(3000);
            OnSoundEncoded();
        }

        protected virtual void OnSoundEncoded()
        {
            if (soundEncoded != null)
                soundEncoded(this, EventArgs.Empty);
        }
    }
}

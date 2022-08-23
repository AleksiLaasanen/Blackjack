using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Sounds
    {
        public void playWinSound()
        {
            SoundPlayer winSound = new SoundPlayer(@"c:\");
            winSound.Play();
        }
        public void playLoseSound()
        {
            SoundPlayer loseSound = new SoundPlayer(@"c:\");
            loseSound.Play();
        }
        public void playCardSound()
        {
            SoundPlayer cardSound = new SoundPlayer(@"c:\");
            cardSound.Play();
        }
    }
}

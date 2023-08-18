using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    internal class Mpg : PlayerHandler
    {
        public override void Play(string filePath)
        {
            if (filePath.EndsWith(".mpg"))
            {
                Console.WriteLine("{0} dosyası oynatılıyor mpgplayer...", filePath);
            }
            else
            {
                if (_SonrakiHandler != null)
                    _SonrakiHandler.Play(filePath);
            }
        }
    }
}

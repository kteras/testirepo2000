using System;
using ElainLuokat;

namespace Periytyminen
{
    class Program
    {
        private static void TulostaTiedot(Elain elain)
        {
            string tuloste = elain.PalautaElaimenNimi() + " on " + elain.PalautaElaimenIka() + " vuotias ";
            if (elain.PalautaOnLihanSyoja())
            {
                tuloste += "lihansyoja.";
            }
            else
            {
                tuloste += "eika ole lihansyoja.";
            }
            Console.WriteLine(tuloste);
        }
        static void Main(string[] args)
        {
            Kissa katti = new Kissa();
            katti.AsetaElaimenNimi("Hilda");
            katti.AsetaElaimenIka(14);
            katti.AsetaOnLihanSyoja(true);
            TulostaTiedot(katti);
            katti.Kehraa();

            Koira haukku = new Koira();
            haukku.AsetaElaimenNimi("Musti");
            haukku.AsetaElaimenIka(1);
            haukku.AsetaOnLihanSyoja(true);
            TulostaTiedot(haukku);
        }
    }
}

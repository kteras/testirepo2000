using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
    public class Elain
    {
        private int ika;
        private bool OnLihanSyoja;

        public string nimi;


        public void AsetaElaimenIka(int ika)
        {
            if(ika>0)
            {
                this.ika = ika;
            }
        }
        public void AsetaElaimenNimi(string nimi)
        {
            this.nimi = nimi;
        }
        public int PalautaElaimenIka()
        {
            return ika;
        }
        public string PalautaElaimenNimi()
        {
            return nimi;
        }
        public void AsetaOnLihanSyoja(bool syoLihaa)
        {
            OnLihanSyoja = syoLihaa;
        }
        public bool PalautaOnLihanSyoja()
        {
            return OnLihanSyoja;
        }
    }
}

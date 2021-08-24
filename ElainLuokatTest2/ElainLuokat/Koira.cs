using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
    public class Koira {
        private int ika;
        public string nimi;

        public Koira()
        {
            nimi = "Haukkuli";
            ika = 0;
        }
        public Koira(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        /*public AsetaKoiranNimi(<parameterina Koiran nimi>) - tallentaa Koiran nimen public-muuttujaan 
       - public <tietotyyppi>PalautaKoiranNimi() - palauttaa Koiran nimen (return)
       - public <tietotyyppi> PalautaKoiranIka() - palauttaa Koiran iän (return)*/

        public bool AsetaKoiranNimi(string nimi)
        {
            if (nimi.ToLower().Equals("musti"))
            {
                // TAI: if(nimi.Equals("hilda",StringComparison.CurrentCultureIgnoreCase)) {
                // nimi on kielletty
                return false;
            }
            else
            {
                // nimi on ok
                this.nimi = nimi;
                return true;
            }
            this.nimi = nimi;
        }
        public bool AsetaKoiranIka(int ika)
        {
            if (ika < 0)
            {
                // negatiivinen ika
                return false;
            }
            else
            {
                // ika >= 0
                this.ika = ika;
                return true;
            }
        }
        public string PalautaKoiranNimi()
        {
            return nimi;
        }
        public int PalautaKoiranIka()
        {
            return ika;
        }

        public override string ToString()
        {
            // Koira: Miuku, ikä 0.
            return "Koira: " + nimi + ", ika " + ika + ".";
        }
    }
}

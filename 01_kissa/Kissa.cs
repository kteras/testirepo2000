using System;

namespace _01_kissa
{
    class Kissa {
        private int ika;
        public string nimi;

        public Kissa() {
            nimi="Miuku";
            ika=0;
        }
        public Kissa(int ika, string nimi) {
            this.ika=ika;
            this.nimi=nimi;
        }

        /*public AsetaKissanNimi(<parameterina kissan nimi>) - tallentaa kissan nimen public-muuttujaan 
       - public <tietotyyppi>PalautaKissanNimi() - palauttaa kissan nimen (return)
       - public <tietotyyppi> PalautaKissanIka() - palauttaa kissan iän (return)*/

        public bool AsetaKissanNimi(string nimi) {
            if(nimi.ToLower().Equals("hilda")) {
            // TAI: if(nimi.Equals("hilda",StringComparison.CurrentCultureIgnoreCase)) {
                // nimi on kielletty
                return false;
            } else {
                // nimi on ok
                this.nimi=nimi;
                return true;
            }
            this.nimi=nimi;
        }
        public bool AsetaKissanIka(int ika) {
            if(ika<0) {
                // negatiivinen ika
                return false;
            } else {
                // ika >= 0
                this.ika=ika;
                return true;
            }
        }
        public string PalautaKissanNimi() {
            return nimi;
        }
        public int PalautaKissanIka() {
            return ika;
        }

        public override string ToString() {
            // Kissa: Miuku, ikä 0.
            return "Kissa: "+nimi+", ika "+ika+".";
        }

    }
}
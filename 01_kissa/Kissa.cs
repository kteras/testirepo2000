using System;

namespace _01_kissa
{
    class Kissa {
        private int ika;
        public string nimi;

        public Kissa() {}
        public Kissa(int ika, string nimi) {
            this.ika=ika;
            this.nimi=nimi;
        }

        /*public AsetaKissanNimi(<parameterina kissan nimi>) - tallentaa kissan nimen public-muuttujaan 
       - public <tietotyyppi>PalautaKissanNimi() - palauttaa kissan nimen (return)
       - public <tietotyyppi> PalautaKissanIka() - palauttaa kissan iän (return)*/

        public void AsetaKissanNimi(string nimi) {
            this.nimi=nimi;
        }
        public string PalautaKissanNimi() {
            return nimi;
        }
        public int PalautaKissanIka() {
            return ika;
        }

    }
}
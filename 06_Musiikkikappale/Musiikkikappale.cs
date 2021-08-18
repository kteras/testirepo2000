using System;

namespace _06_Musiikkikappale
{
    class Musiikkikappale {
        private string nimi;
        private int pituus; // sekuntteina

        public Musiikkikappale(String kappaleenNimi, int kappaleenPituus) {
            nimi=kappaleenNimi;
            pituus=kappaleenPituus;
        }

        public string Nimi() {
            return nimi;
        }

        public int Pituus() {
            return pituus;
        }
    }
}
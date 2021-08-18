using System;

namespace _07_Mitta
{
    class Mittari {
        private int _mitta;

        //a. Metodi public void Lisaa() kasvattaa oliomuuttujan _mitta arvoa yhdellä. Ei kasvata arvoa yli viiden.
        public void Lisaa() {
            if(_mitta<5) {
                _mitta++;
            }
            // TAI:
            //if(_mitta==5) {
            //    return;
            //}
            //_mitta++;
        }
        //b. Metodi public void Vahenna() vähentää oliomuuttujan _mitta arvoa yhdellä. Ei vähennä arvoa negatiiviseksi.
        public void Vahenna() {
            if(_mitta==0) {
                return;
            }
            _mitta--;
        }
        //c. Metodi public int Mitta() palauttaa oliomuuttujan _mitta arvon.
        public int Mitta() {
            return _mitta;
        }
        //d. Metodi public boolean Taynna() palauttaa true mikäli oliomuuttujan _mitta on viisi, palauttaa muulloin false.
        public bool Taynna() {
            if(_mitta==5) {
                return true;
            } else {
                return false;
            }
        }
    }
}
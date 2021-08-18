using System;

namespace _05_Velka
{
    class Velka {
        private double _saldo;
        private double _korkoProsentti;

        public Velka(double saldoAlussa, double korkoProsentti) {
            _saldo=saldoAlussa;
            _korkoProsentti=korkoProsentti;
        }

        public void TulostaSaldo() {
            System.Console.WriteLine("Saldo="+_saldo);
        }
        public void OdotaVuosi() {
            _saldo=_saldo * (1+_korkoProsentti);
        }
    }

}
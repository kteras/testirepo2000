using System;

namespace _08_Maksukortti
{
    public class Maksukortti {
        private double saldo;
        public Maksukortti(double alkusaldo) { 
            saldo=alkusaldo;
        }

        public override String ToString() {
            // "Kortilla on rahaa X euroa"
            return "Kortilla on rahaa "+String.Format("{0:0.00}",saldo)+" euroa";
            // vaihtoehtoinen syntaksi
            //return $"Kortilla on rahaa {saldo} euroa";
        }

        public void syoEdullisesti() { 
            // 2.60 
            // saldo=saldo-2.60
            saldo-=2.60;
        }

        public void syoMaukkaasti() {
            // 4.60
            saldo-=4.60;
        }
    }
}
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
            //return "Kortilla on rahaa "+String.Format("{0:0.00}",saldo)+" euroa";
            // vaihtoehtoinen syntaksi
            return $"Kortilla on rahaa {saldo:N2} euroa";
        }

        public void SyoEdullisesti() { 
            // 2.60
            if(saldo>=2.60) {
                // saldo=saldo-2.60
                saldo-=2.60;
            }
        }

        public void SyoMaukkaasti() {
            // 4.60
            if(saldo>=4.60) {
                saldo-=4.60;
            }
        }

        public void LataaRahaa(double summa) {
            //if(summa>0) {  - ajaa saman asian
            if(summa>=0) {
                saldo+=summa;
            }
        }
    }
}
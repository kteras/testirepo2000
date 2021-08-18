using System;

namespace _05_Velka
{
    class Program
    {
        static void Main(string[] args)
        {
            Velka v=new Velka(1000,0.1);
            v.TulostaSaldo();
            v.OdotaVuosi();
            v.TulostaSaldo();
            v.OdotaVuosi();
            v.TulostaSaldo();
            v.OdotaVuosi();
            v.TulostaSaldo();
        }
    }
}

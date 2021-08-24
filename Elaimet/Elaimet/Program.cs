using System;
using ElainLuokat;

namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira haukku = new Koira();
            Console.WriteLine(haukku.AsetaKoiranNimi("Max"));
            Console.WriteLine(haukku.PalautaKoiranNimi());
            Console.WriteLine(haukku.AsetaKoiranNimi("musti"));
            Console.WriteLine(haukku.PalautaKoiranNimi());
        }
    }
}

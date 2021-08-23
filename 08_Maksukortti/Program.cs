using System;

namespace _08_Maksukortti
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luo Pekan kortti. Kortin alkusaldo on 20 euroa
            Maksukortti pekanKortti = new Maksukortti(20); 
            //Luo Matin kortti. Kortin alkusaldo on 30 euroa
            Maksukortti matinKortti = new Maksukortti(30);
            //Pekka syö maukkaasti
            pekanKortti.SyoMaukkaasti();
            //Matti syö edullisesti
            matinKortti.SyoEdullisesti();
            //Korttien arvot tulostetaan (molemmat omalle rivilleen, rivin alkuun kortin omistajan nimi)
            System.Console.WriteLine("Pekka: "+pekanKortti);
            System.Console.WriteLine("Matti: "+matinKortti);
            //Pekka lataa rahaa 20 euroa
            pekanKortti.LataaRahaa(20);
            //Matti syö maukkaasti
            matinKortti.SyoMaukkaasti();
            //Korttien arvot tulostetaan (molemmat omalle rivilleen, rivin alkuun kortin omistajan nimi)
            System.Console.WriteLine("Pekka: "+pekanKortti);
            System.Console.WriteLine("Matti: "+matinKortti);
            //Pekka syö edullisesti
            pekanKortti.SyoEdullisesti();
            //Pekka syö edullisesti
            pekanKortti.SyoEdullisesti();
            //Matti lataa rahaa 50 euroa
            matinKortti.LataaRahaa(50);
            //Korttien arvot tulostetaan (molemmat omalle rivilleen, rivin alkuun kortin omistajan nimi)
            System.Console.WriteLine("Pekka: "+pekanKortti);
            System.Console.WriteLine("Matti: "+matinKortti);
        }
    }
}

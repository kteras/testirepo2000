using System;

namespace _08_Maksukortti
{
    class Program
    {
        static void Main(string[] args)
        {
            Maksukortti kortti = new Maksukortti(10);
            Console.WriteLine("Pekka: " + kortti); 
            kortti.LataaRahaa(-15);
            Console.WriteLine("Pekka: " + kortti); 
        }
    }
}

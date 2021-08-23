using System;

namespace _08_Maksukortti
{
    class Program
    {
        static void Main(string[] args)
        {
            Maksukortti kortti = new Maksukortti(5); 
            Console.WriteLine(kortti); 
            kortti.SyoMaukkaasti(); 
            Console.WriteLine(kortti); 
            kortti.SyoMaukkaasti(); 
            Console.WriteLine(kortti);
        }
    }
}

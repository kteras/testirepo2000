using System;

namespace _01_kissa
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ota Uusi Kissa-luokka Program.cs:ssä käyttöön luomalla uusi kissa-olio parametrittomalla konstruktorilla. 
            Kissa katti=new Kissa();
            //2. Anna sen jälkeen kissalle nimi suoraan public muuttujalla.
            katti.nimi="Kille";
            //3. Tulosta kissan nimi.
            System.Console.WriteLine(katti.PalautaKissanNimi());
            // TAI: System.Console.WriteLine(katti.nimi);

            //4. Anna kissalle uusi nimi public -metodilla
            katti.AsetaKissanNimi("Kalle");
            //5. Tulosta kissan nimi. 
            System.Console.WriteLine(katti.PalautaKissanNimi());
            //6. Tulosta kissan ikä. 
            System.Console.WriteLine(katti.PalautaKissanIka());
            //7. Tee uusi kissa-olio ja anna ikä ja nimi konstruktorissa.
            Kissa toinenkissa = new Kissa(14,"Toinenkissa");
            //8. Tulosta uuden olion tiedot nimi ja ikä.
            System.Console.WriteLine(toinenkissa.PalautaKissanNimi()+" ika: "+toinenkissa.PalautaKissanIka());
        }
    }
}

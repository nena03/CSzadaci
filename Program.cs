using System;

namespace Nasledjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kuvar kuvar = new Kuvar("Mark", 3, 400);
           
            kuvar.IspisStanjaZaposlenog();
            kuvar.DajIznos(100);
            kuvar.IspisStanjaZaposlenog();

            Konobar konobar = new Konobar("Milan", 4, 300, 100);
           
            konobar.IspisStanjaZaposlenog();
            konobar.DajIznos(100);
            konobar.IspisStanjaZaposlenog();
            


            Console.WriteLine("Baksis konobara" + konobar.Baksis);

        }
    }
}

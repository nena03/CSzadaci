using System;
using System.Collections.Generic;
using System.Text;

namespace Nasledjivanje
{
     sealed class Konobar : Zaposleni
    {
       
        public int Baksis { get; set; }
        public Konobar( ) { }
        public Konobar(string ime, int id, int plata,int baksis)
        {
            Plata = plata;
            Id = id;
            Ime = ime;
            Baksis = baksis; }
        public override void DajIznos(int iznos)
        { Plata = Plata + iznos; }
        public override void IspisStanjaZaposlenog()
        {
            Console.WriteLine($"Ime konobara: { Ime};\nId: {Id};\nPlata:{Plata};\nBaksis: {Baksis};\n");
        }
    }
}

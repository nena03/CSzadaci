using System;
using System.Collections.Generic;
using System.Text;

namespace Nasledjivanje
{
    class Kuvar : Zaposleni
    {
        public Kuvar(string ime, int id, int plata)
        {
            Plata = plata;
            Id = id;
            Ime = ime;
        }

        public override void IspisStanjaZaposlenog()
        {
            Console.WriteLine($"Ime kuvara:{ Ime};\nId: { Id};\nPlata:{Plata};");
        }
        public override void DajIznos(int iznos)
        { Plata = Plata + iznos; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Nasledjivanje
{
    class Zaposleni
    {
        protected string ime;
        protected int id;
        protected int plata;

       public string Ime { get { return ime; } set { ime = value; } }
       public int Id { get { return id; } set { id = value; } }
        public int Plata
        {
            get { return plata; }
            set
            {
                
                 plata = value;
            }

        }

        public Zaposleni ()
        {

        }

        public Zaposleni( string ime, int id, int plata)
        {
            this.ime = ime;
            this.id = id;
            this.plata = plata;


        }
        public virtual void DajIznos(int iznos)
        {
            this.plata = this.plata + iznos;

        }
        
        
        public  virtual void  IspisStanjaZaposlenog()
        {
            Console.WriteLine($"Ime:, { this.ime};\nId:, {this.id};\nPlata:, {this.plata};\n");
        }
    }
}

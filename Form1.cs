using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Proslava;

namespace Proslava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Proslava[] pr = new Proslava[100];
        int n = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            StreamReader f = new StreamReader("proslava.txt");
            while (!f.EndOfStream)
            {
                    string ime = f.ReadLine();
                    string prezime = f.ReadLine();
                    int godine = Convert.ToInt32(f.ReadLine());
                    string telefon = f.ReadLine();
                    pr[n] = new Osoba(ime, prezime, godine, telefon);
                    listBox1.Items.Add(pr[n].Prikaz());
                    n++;
            }
            f.Close();
            

            for (int i = 0; i < pr.Length; i++)
            {
                for (int j = i + 1; j < pr.Length; j++)
                {
                    if (pr[j].StarijeOd(pr[i]))
                    {
                        Proslava pom = pr[i];
                        pr[i] = pr[j];
                        pr[j] = pom;
                    }
                }
            }

            for (int i = 0; i < pr.Length; i++)
            {
                if (pr[i] is Osoba)
                    listBox2.Items.Add("Osoba: " + pr[i].Info());
               
            }

        }
    }
}

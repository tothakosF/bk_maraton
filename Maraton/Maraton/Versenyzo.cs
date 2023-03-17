using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton
{
    internal class Versenyzo
        {
            public string Nev { get; set; }
            public int Szulev { get; set; }
            public string Kategoria { get; set; }
            public string Orszag { get; set; }
            public string Csapat { get; set; }
            public string Varos { get; set; }
            public string Rajtszam { get; set; }
            public string Feltav { get; set; }
            public string Eredmeny { get; set; }

            public Versenyzo(string sor)
            {
                string[] resz = sor.Split(';');
                Nev = resz[0];
                Szulev = int.Parse(resz[1]);
                Kategoria = resz[2];
                Orszag = resz[3];
                Csapat = resz[4];
                Varos = resz[5];
                Rajtszam = resz[6];
                Feltav = resz[7];
                Eredmeny = resz[8];
            }
        }
}
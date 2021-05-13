using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanac_prodavnica
{

    public class MlečniProizvod : Artikal
    {
        public MlečniProizvod(string naziv, int cena, DateTime rok_trajanja, string ambalaza, string jedinica_prodaje, string proizvodjac, string opis_cuvanja, ArtikalDelegate eh) 
             :base(naziv, cena, rok_trajanja, ambalaza, jedinica_prodaje, proizvodjac,"Cuvati u frizideru na temperaturi ne visoj od 10C",eh)
        {
            
        }
        public override int Cena()
        {//! neki handler? ili ex??
            //if (rok_trajanja > DateTime.Now) { Pokvaren?.Invoke(this); }
            int c = base.Cena();
            if( rok_trajanja.AddDays(10)>DateTime.Now ) { return (int)(0.5 * c); }
            return c;
        }
    }
}
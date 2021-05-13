using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanac_prodavnica
{
    class KvarljiviArtikli2:Artikl2
    {//hmm a ona fabrika il sta vec,, i lager me podseca na to kao napravi mi to i to
        private DateTime rok_trajanja;
        private string opis_cuvanja;
        private double popust;
        public KvarljiviArtikli2(string naziv, int cena, string ambalaza, string jedinica_prodaje, string proizvodjac, 
            Vrsta_artikla kategorija, DateTime rok_trajanja,string opis_cuvanja, double popust):base(naziv, cena, ambalaza, jedinica_prodaje, proizvodjac, kategorija)
        {
            this.rok_trajanja = rok_trajanja;
            this.opis_cuvanja = opis_cuvanja;
            this.popust = popust;
        }
        public override int Cena()
        {
            return (int)( base.Cena()*popust);
        }
    }
}

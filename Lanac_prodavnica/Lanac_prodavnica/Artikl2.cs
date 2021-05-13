using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanac_prodavnica
{// ili artikl 3 gde imamo kvarljive artikle i trajnje, kvarljiv imaju opis, datum, popust
    public enum Vrsta_artikla { 
        TrajniProizvod=0, MlecniProizvod=1, ObradjenoMeso=2, SvezeMeso=3,ZaledjeniProgram=4, Pecivo_KuvanaHrana=5
    }
    class Artikl2
    {
        private string proizvodjac;
        private string naziv;
        /// <summary>
        /// Broj dana pod kojim je proizvod pod garancijom
        /// </summary>
        //protected DateTime rok_trajanja;//!
        protected int cena;
        /// <summary>
        /// Vrsta ambalaze i njene karakteristike
        /// </summary>
        private string ambalaza;
        /// <summary>
        /// Na meru, po komadu...
        /// </summary>
        private string jedinica_prodaje;
        private Vrsta_artikla kategorija;
        //private string opis_cuvanja;//!
        public virtual int Cena() {
            return cena;
        }

        protected Artikl2(string _naziv, int _cena, string _ambalaza, string _jedinica_prodaje, string _proizvodjac, Vrsta_artikla _kategorija)
        {
            naziv = _naziv;
            cena = _cena;
           
            ambalaza = _ambalaza;
            jedinica_prodaje = _jedinica_prodaje;
            proizvodjac = _proizvodjac;
            _kategorija = kategorija;
           
        }
        public Artikl2(string _naziv, int _cena, string _ambalaza, string _jedinica_prodaje, string _proizvodjac)
        {
            naziv = _naziv;
            cena = _cena;

            ambalaza = _ambalaza;
            jedinica_prodaje = _jedinica_prodaje;
            proizvodjac = _proizvodjac;
            kategorija = Vrsta_artikla.TrajniProizvod;

        }

    }
}


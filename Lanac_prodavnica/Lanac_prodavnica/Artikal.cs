using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanac_prodavnica
{
    public abstract class Artikal
    {
        private Guid barkod;
        private string proizvodjac;
        private string naziv;
        /// <summary>
        /// datum isteka roka trajanja, null ako je nekvarljiv 
        /// </summary>
        protected DateTime rok_trajanja;
        protected int cena;
        /// <summary>
        /// Vrsta ambalaze i njene karakteristike
        /// </summary>
        private string ambalaza;
        /// <summary>
        /// Na meru, po komadu...
        /// </summary>
        private string jedinica_prodaje;
        /// <summary>
        /// ako je nekvarljiv artikl opis ne postoji
        /// </summary>
        private string opis_cuvanja;
        public virtual int Cena() { if (rok_trajanja != null && rok_trajanja > DateTime.Now) { Pokvaren?.Invoke(this); throw new Exception("artikl pokvaren"); } return cena; }//vraca cenu, snizenu ako je pred istek roka

        public delegate void ArtikalDelegate(object sender);
        public event ArtikalDelegate Pokvaren;

        public override string ToString()
        {
            return naziv + " " + cena.ToString() + " /" + barkod.ToString();
        }

        public Artikal(string _naziv, int _cena, DateTime _rok_trajanja, string _ambalaza, string _jedinica_prodaje, string _proizvodjac, string _opis_cuvanja, ArtikalDelegate eh)
        {
            naziv = _naziv;
            cena = _cena;
            rok_trajanja = _rok_trajanja;
            ambalaza = _ambalaza;
            jedinica_prodaje = _jedinica_prodaje;
            proizvodjac = _proizvodjac;
            opis_cuvanja = _opis_cuvanja;
            barkod = Guid.NewGuid();
            if (eh != null) Pokvaren += eh;
        }
        public string Naziv { get { return naziv; } }
    }
}
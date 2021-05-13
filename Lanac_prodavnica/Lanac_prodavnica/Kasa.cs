using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanac_prodavnica
{
    public class Kasa
    {

        public Kasa(KasaDelegate eh,int brojkase)
        {
            otkucaniRacuni = new List<Racun>();
            brojKase = brojkase;

        }
        private List<Racun> otkucaniRacuni;
        /// <summary>
        /// Redni broj kase, jedinstven na nivou čitave kompanije
        /// </summary>
        private int brojKase;
        private Racun trenutni;

        public delegate bool KasaDelegate(object sender, EventArgs args);

        public event KasaDelegate SkidanjeSaLagera;


        public void NoviRacun(Kasir kasir) {
            if (trenutni != null) throw new Exception("prethodni nije zavrsen");
            trenutni = new Racun(brojKase,kasir);
        }//sta sa starim
        public void DodajArtikl(Artikal a) { if (trenutni == null) throw new Exception("napravi novi racun"); trenutni.DodajArtikl(a); }
        public void UkloniArtikl(Artikal a) {
            if (trenutni == null) throw new Exception("napravi novi racun");
            trenutni.UkloniArtikl(a);
           
        }
        public void ZavrsiRacun()
        {
            if (trenutni == null) throw new Exception("racun ne postoji");

            if (!SkidanjeSaLagera(this, new EventArgs())) throw new Exception("nema artikala na lageru");

            trenutni.ZavrsiRacun();
            otkucaniRacuni.Add(trenutni);
            trenutni = null;
        }

        public List<Racun> PrikazRacunaPoSmenama(Kasir kasir)
        {
            List<Racun> rez = new List<Racun>();
            foreach (var racun in otkucaniRacuni)
            {
                if (racun.Kasir == kasir) { rez.Add(racun); }
            }
            return rez;
        }

        public List<Racun>  PrikazRacunaPoDanima(DateTime dan)
        {
            List<Racun> rez = new List<Racun>();
            foreach (var racun in otkucaniRacuni)
            {
                if (racun.Datum.Day == dan.Day) { rez.Add(racun); }
            }
            return rez;
        }
    }
}
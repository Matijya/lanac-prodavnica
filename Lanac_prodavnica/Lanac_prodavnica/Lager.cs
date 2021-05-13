using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanac_prodavnica
{
    class Lager
    {
        List<Artikal> spisak;
        //mozda ovde da cuva prodavnicu?
        public void DodajArtikal(Artikal artikal) { spisak.Add(artikal); }   //!dobavljanje iz centralnog, handler, u prodavnici+provera?
        public void DodajArtikle(List<Artikal> lista) {
            foreach (var t in spisak)
            {
                DodajArtikal(t);
            };
        }
        public void UkloniArtikal(Artikal artikal) { if (!spisak.Remove(artikal)) throw new Exception("Artikal ne postoji"); }
        public void UkloniArtikle(List<Artikal> lista) {
            foreach (var t in spisak)
            {
                UkloniArtikal(t);
            }
        }

        public Lager() { spisak = new List<Artikal>(); }
        public override string ToString()
        {
            string rez="Artikli na lageru:"+Environment.NewLine;

            foreach (var a in spisak)
            {
                rez += a.ToString() + Environment.NewLine ;
            }
            rez += "----------------------" + Environment.NewLine;
            return rez;
        }
    }
}

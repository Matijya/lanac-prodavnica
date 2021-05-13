using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanac_prodavnica
{
    public class Lager1
    {
        Spisak_artikla spisak;
        public void DodajArtikal(Artikal artikal, int komada) { spisak.DodajArtikal(artikal,komada); }
        public void DodajArtikle(Spisak_artikla spisak) { spisak.DodajArtikle(spisak); }
        public void UkloniArtikal(Artikal artikal, int komada) { spisak.UkloniArtikal(artikal, komada); }
        public void UkloniArtikle(Spisak_artikla spisak) { spisak.UkloniArtikle(spisak); }

        public Lager1() { spisak = new Spisak_artikla(); }
        public override string ToString()
        {
            return spisak.ToString();
        }

    }
}
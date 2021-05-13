using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanac_prodavnica
{
    public class MalaProdavnica : Prodavnica
    {
        
        // druge prodavnice uraditi slicno
        public MalaProdavnica(int P,ProdavnicaDelegate eh,Kasa kasa) : base(P,eh)
        {
            slobodnamesta = new Dictionary<string, int>() {
                {"menadzer",1 },{"kasir",2 },{ "aranzer",2}

            };
            kase.Add(kasa);
        }
        public void DodajZaposlenog(Radnik r)// sto da dodajemo kad je fiksan broj, i dal se dodaje iz centralnog
        {
            if (slobodnamesta.ContainsKey(r.Naziv) && slobodnamesta[r.Naziv] > 0)
            {
                zaposleni.Add(r);
                slobodnamesta[r.Naziv]--;

            }
            else throw new Exception("ne treba nam taj radnik");
        }

        public override void DodajNaLager(Artikal a)
        {
            if (a is Pecivo_KuvanaHrana || a is SvežeMeso || a is ObrađenoMeso) throw new Exception("prodavnica ne prodaje artikl");
            base.DodajNaLager(a);
        }

        public override void OtpustiRadnika()
        {
            throw new NotImplementedException();
        }

        public override bool PremestiRadnika()
        {
            throw new NotImplementedException();
        }

        public override bool PrimiRadnika()
        {
            throw new NotImplementedException();
        }
    }
}
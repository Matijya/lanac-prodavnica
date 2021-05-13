using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanac_prodavnica
{
    public class MalaProdavnica : Prodavnica
    {
        static private int ogranicenjeZaMenadzera = 1;
        static private int ogranicenjeZaKasira = 2;
        static private int ogranicenjaZaAranzera = 2;

        public MalaProdavnica(int P) : base(P)
        {
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
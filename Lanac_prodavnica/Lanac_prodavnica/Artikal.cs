using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanac_prodavnica
{
    public abstract class Artikal
    {
        private string proizvodjac;
        private string naziv;
        /// <summary>
        /// Broj dana pod kojim je proizvod pod garancijom
        /// </summary>
        private int rok_trajanja;
        private int cena;
        /// <summary>
        /// Vrsta ambalaze i njene karakteristike
        /// </summary>
        private string ambalaza;
        /// <summary>
        /// Na meru, po komadu...
        /// </summary>
        private string jedinica_prodaje;
    }
}
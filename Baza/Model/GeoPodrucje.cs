﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Model
{
    public class GeoPodrucje
    {
        public GeoPodrucje() { }
        public GeoPodrucje(string sifra, string ime, int sirina)
        {
            this.Sifra = sifra;
            this.Ime = ime;
            this.Sirina = sirina;
        }

        public string Sifra { get; set; }
        public string Ime { get; set; }

        public int Sirina { get; set; }

        public override string ToString()

        {
            return $"SIFRA: {Sifra} IME: {Ime} SIRINA: {Sirina} ";
        }


    }
}

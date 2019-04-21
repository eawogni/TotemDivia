using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotemBiblio
{
    public class Arret
    {
        private string nom;
        private string refs;

        public Arret(string nom, string refs)
        {
            this.nom = nom;
            this.refs = refs;
        }

       

        public string Nom { get => nom; }
        public string Refs { get => refs; }

        public override string ToString()
        {
            return this.nom;
        }
    }
}

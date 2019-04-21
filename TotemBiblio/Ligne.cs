using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotemBiblio
{
    public class Ligne
    {
        private string nom;
        private string code;

        public Ligne(string nom, string code)
        {
            this.nom = nom;
            this.code = code;
        }
      

        public string Code { get => code; }
        public string Nom { get => nom; }

        public override string ToString()
        {
            return this.nom;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotemBiblio
{
   public class Horaire
    {
        private string heure;

        public Horaire(string h)
        {
            this.heure = h;
        }

        public string Heure { get => heure;}

        public override string ToString()
        {
            return this.heure;
        }
    }
}

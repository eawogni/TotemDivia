using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totem
{
    public class Arret
    {
        private string nom;
        private int refs;

        public Arret(string nom, int refs)
        {
            this.nom = nom;
            this.refs = refs;
        }

        public string Nom { get => nom; }
        public int Refs { get => refs; }
    }
}

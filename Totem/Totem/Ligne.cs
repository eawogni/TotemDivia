using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totem
{
    public class Ligne
    {
        private string nom;
        private int code;

        public Ligne(string nom, int code)
        {
            this.nom = nom;
            this.code = code;
        }

        public int Code { get => code; }
        public string Nom { get => nom; }
    }

    
}

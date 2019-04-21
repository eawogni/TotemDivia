using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totem
{
    interface ITotem
    {
        List<Ligne> GetListeLignes();
        List<Arret> GetListeArrets();
        List<Horaire> GetListeHoraires();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotemBiblio
{
    interface ITotem
    {
        Task<List<Ligne>> GetListeLignes();
        Task<List<Arret>> GetListeArrets(Ligne l, string sens);
        Task<List<Horaire>> GetListeHoraires(Arret arret);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotemBiblio
{
    public class MockTotemAPI : ITotem
    {
        private static MockTotemAPI instance = null;

        private MockTotemAPI()
        {


        }

        public static MockTotemAPI GetInstance()
        {
            if (instance == null)
            {
                instance = new MockTotemAPI();

            }
            return instance;
        }
        public async Task<List<Arret>> GetListeArrets(Ligne l, string sens)
        {
            List<Arret> listeArrets = new List<Arret>();
           
            for (int i = 0; i < 5; i++)
                
            {
                Random rd = new Random();
                int refs = rd.Next();
                Arret arret = new Arret("Arret "+i, refs+"");
                listeArrets.Add(arret);

               
            }
            return listeArrets;
        }

        public async Task<List<Horaire>> GetListeHoraires(Arret arret)
        {
            List<Horaire> listeHoraire = new List<Horaire>();

            for (int i = 0; i < 2; i++)

            {
                Random rd = new Random();
                int h = rd.Next(1,24);
                int min = rd.Next(0,60);
           
                String heure = h + ":" + min;
                Horaire passage = new Horaire(heure);
                listeHoraire.Add(passage);


            }
            return listeHoraire;
        }

        public  async Task<List<Ligne>> GetListeLignes()
        {
            List<Ligne> listeLigne = new List<Ligne>();

            for (int i = 0; i < 10; i++)

            {
                Random rd = new Random();
                    int refs = rd.Next(1500, 3500);

                Ligne l = new Ligne("Ligne " + i, refs + "");
                listeLigne.Add(l);


            }
            return listeLigne;
        }

      
    }
}

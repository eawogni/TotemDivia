using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Xml;
using TotemBiblio;

namespace Totem.Droid
{
    [Activity(Label = "Horaires_Activity")]
    public class Horaires_Activity : Activity
    {
        IList<string> DonneesRecues = new List<string>();
        private List<Horaire> listeHoraires= new List<Horaire>();
        protected  async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ActionBar.Hide();

            SetContentView(Resource.Layout.horraires_activity);
            this.DonneesRecues = Intent.GetStringArrayListExtra("donnees");

            TextView txtNomArret = (TextView)FindViewById(Resource.Id.txtNomArret);
            txtNomArret.Text = DonneesRecues[0];

            //recupérartions des horraires pour l'arret spécifié
            Arret ar = new Arret(DonneesRecues[0], DonneesRecues[1]);

            this.listeHoraires = await MockTotemAPI.GetInstance().GetListeHoraires(ar);

            ListView listBoxHoraire = (ListView)FindViewById(Resource.Id.listHoraires);
            listBoxHoraire.Adapter = new CustumListView(this, null,null,this.listeHoraires);




        }
       
    }
}
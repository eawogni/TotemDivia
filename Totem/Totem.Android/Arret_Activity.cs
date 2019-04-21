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
    [Activity(Label = "Arret_Activity")]
    public class Arret_Activity : Activity
    {
        private List<Arret> listeArrets = new List<Arret>();
        private List<string> listeRefs = new List<string>();
        IList<string> DonneesRecu = new List<string>();
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ActionBar.Hide();
          

            // Create your application here

            SetContentView(Resource.Layout.arret_activity);
            this.DonneesRecu =  Intent.GetStringArrayListExtra("donnee");       //Recupération des données(nomligne,codeLigne et sens )de la ligne de ransport

            TextView txtLigne = (TextView)FindViewById(Resource.Id.txtNomLigne);
            txtLigne.Text = this.DonneesRecu[0];  //on  affiche la ligne pour laquelle on gère l'arret

            Ligne l = new Ligne(this.DonneesRecu[0], this.DonneesRecu[1]);
            this.listeArrets = await  MockTotemAPI.GetInstance().GetListeArrets(l, this.DonneesRecu[2]);                                           //on récupère la liste des arrets pour pour laligne et le sens choisis

            //Gestion de la listView
            ListView listViewArrets = FindViewById<ListView>(Resource.Id.listArret); //on
            listViewArrets.Adapter = new CustumListView(this,null, listeArrets,null);
            listViewArrets.ItemClick += ListViewArrets_ItemClick;
           
            
           
            
        }

        private void ListViewArrets_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            List<string> Donnees = new List<string>
            {
                this.listeArrets[e.Position].Nom,       //nom Arret
                this.listeArrets[e.Position].Refs       //refs associée à l'arret
                
            };
            var intent = new Intent(this,typeof(Horaires_Activity));
            intent.PutStringArrayListExtra("donnees", Donnees);

            StartActivity(intent);
        }

       

        
    }
}
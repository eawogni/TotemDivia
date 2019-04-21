using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.Xml;
using TotemBiblio;

namespace Totem.Droid
{
    [Activity(Label = "Totem.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Ligne> ListeLigne = new List<Ligne>();
        private string sens;


        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            ActionBar.Hide();

         

           //Gesstion de la listeBox
           var listBox = FindViewById<Spinner>(Resource.Id.spinner1);
            listBox.Prompt = "Choisir un sens ";
            var Adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.Sens, Android.Resource.Layout.SimpleSpinnerItem);
            Adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleDropDownItem1Line);
            listBox.Adapter = Adapter;  
            listBox.ItemSelected += ListBox_ItemSelected;



            this.ListeLigne = await MockTotemAPI.GetInstance().GetListeLignes();
            //this.GetListeLigneLignes();
            ListView ListeLigneLignes = FindViewById<ListView>(Resource.Id.listeLignes);
           
            ListeLigneLignes.Adapter = new CustumListView(this, ListeLigne,null,null);
            ListeLigneLignes.ItemClick += ListeLigneLignes_ItemClick;
          

            


        }

       



        
        private void ListBox_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            switch (e.Position)
            {
                case 0:
                    {
                        this.sens = GetString(Resource.String.sens0);
                        break;
                    }
                case 1:
                    {
                        this.sens = GetString(Resource.String.sens1)  ;
                       
                       
                        break;
                    }
            }
        }


        private void ListeLigneLignes_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
          
            //e.Parent.GetChildAt(e.Position).SetBackgroundColor(Android.Graphics.Color.Blue);
         


            List<string> Donnees = new List<string>
            {
                this.ListeLigne[e.Position].Nom,
                 this.ListeLigne[e.Position].Code,
                this.sens
            };

          


            var intent = new Intent(this,typeof(Arret_Activity));
            intent.PutStringArrayListExtra("donnee", Donnees);

           
            StartActivity(intent);
         
        }

       
    }
}



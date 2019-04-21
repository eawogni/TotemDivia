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
using Java.Lang;
using TotemBiblio;

namespace Totem.Droid
{
    class CustumListView : BaseAdapter
    {

        private Context context;
        private List<Ligne> ListeLignes;
        private List<Arret> ListeArrets;
        private List<Horaire> ListeHoraires;
        private List<string> Liste = new List<string>();
        private LayoutInflater inflater;

        public CustumListView(Context context ,List<Ligne> ListeL, List<Arret> ListeA, List<Horaire> ListeH)
        {
            this.ListeLignes = ListeL;
            this.ListeArrets = ListeA;
            this.ListeHoraires = ListeH;
            this.DefinirLaListeActuelle();
            
            inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
        }
        public override int Count
        {
            get { return this.Liste.Count; }
        }


        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View v = inflater.Inflate(Resource.Layout.listViewLayout,parent,false);

            TextView txt = v.FindViewById<TextView>(Resource.Id.txtLigne);
            txt.Text = Liste[position];

            return v;


        }

        public void DefinirLaListeActuelle()
        {
            if (this.ListeLignes != null)
            {
                foreach (Ligne l in this.ListeLignes)
                {
                    this.Liste.Add(l.ToString());
                }
            }else if (this.ListeHoraires != null)
            {
                foreach (Horaire h in this.ListeHoraires)
                {
                    this.Liste.Add(h.ToString());
                }
            }else
            {
                foreach (Arret a in this.ListeArrets)
                {
                    this.Liste.Add(a.ToString());
                }
            }
        }
    }
}
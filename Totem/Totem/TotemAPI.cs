using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totem
{
    class TotemAPI : ITotem
    {
        public List<Arret> GetListeArrets()
        {
            throw new NotImplementedException();
        }

        public List<Horaire> GetListeHoraires()
        {
            throw new NotImplementedException();
        }

        public List<Ligne> GetListeLignes()
        {
            String URLString = "http://timeo3.keolis.com/relais/217.php?xml=1";
            // XmlTextReader reader = new XmlTextReader(URLString);

            XmlDocument doc = new XmlDocument();
            doc.Load(URLString);
            XmlNodeList ListeLigneLine = doc.GetElementsByTagName("ligne");
            foreach (XmlNode n in ListeLigneLine)
            {
                XmlNode node = n.ChildNodes.Item(1);
                string nomLigne = node.InnerText;
                node = n.ChildNodes.Item(0);
                string codeLigne = node.InnerText;

                if (!ListeLigne.Contains(nomLigne))
                {
                    ListeLigne.Add(nomLigne);
                    this.ListeCodeLigne.Add(codeLigne);
                }

            }
        }
}

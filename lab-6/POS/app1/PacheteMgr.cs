using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace app1
{
    class PacheteMgr : ProdusAbstractMgr
    {
        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\labs\\lab-6\\POS\\app1\\Pachete.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/pachete/Pachet");
            foreach (XmlNode nod in lista_noduri)
            {
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int nrProduse = int.Parse(nod["Produse"].InnerText);
                int nrServicii = int.Parse(nod["Servicii"].InnerText);
                Pachet pachet = new Pachet(elemente.Count + 1, nume, codIntern, nrServicii, nrProduse);

                ProduseMgr produse = new ProduseMgr();
                ServiciuMgr servicii = new ServiciuMgr(); 
                produse.Init(pachet);
                servicii.Init(pachet);
                elemente.Add(pachet);
            }
        }
    }
}

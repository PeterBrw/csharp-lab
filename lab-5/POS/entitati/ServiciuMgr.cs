using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace entitati
{
    public class ServiciuMgr : ProdusAbstractMgr
    {
        public void AdaugareServicii(Serviciu serv)
        {
                bool exist = produseServicii.Any(item => item.Id == serv.Id && item.Nume == serv.Nume && item.CodIntern == serv.CodIntern && item.Pret == serv.Pret && item.Categorie == serv.Categorie);

                if (exist)
                {
                    Console.WriteLine("Serviciul exista deja!");
                }
                else
                {
                    produseServicii.Add(serv);
                    Console.WriteLine("Serviciu adaugat!");
                }
        }

        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\labs\\lab-5\\POS\\entitati\\Servicii.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/servicii/Serviciu");
 
            foreach (XmlNode nod in lista_noduri)
            {
                
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;

                Serviciu serv = new Serviciu(produseServicii.Count + 1, nume, codIntern, pret, categorie);

                AdaugareServicii(serv);
            }
        }

        public void AfisareServicii()
        {
            foreach (ProdusAbstract serviciu in produseServicii)
            {
                Console.WriteLine(serviciu.Descriere());
            }
        }
    }
}

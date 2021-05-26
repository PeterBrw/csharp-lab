using entitati;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WFApp
{
    public class ServiciuMgr : ProdusAbstractMgr
    {
        public void AdaugareServicii(Serviciu serv)
        {
            bool exist = elemente.Any(item => item.Nume == serv.Nume && item.CodIntern == serv.CodIntern && item.Pret == serv.Pret && item.Categorie == serv.Categorie);

            if (exist)
            {
                Console.WriteLine("Serviciul exista deja!");
            }
            else
            {
                elemente.Add(serv);
                Console.WriteLine("Serviciu adaugat!");
            }
        }

        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\csharp-lab\\lab-8\\WFApp\\WFApp\\bin\\Debug\\servicii.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/ArrayOfServiciu/Serviciu");

            foreach (XmlNode nod in lista_noduri)
            {

                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;

                Serviciu serv = new Serviciu(elemente.Count + 1, nume, codIntern, pret, categorie);

                AdaugareServicii(serv);
            }
        }

        public void WriteListToXML(List<Serviciu> servicii)
        {
            Type[] types = new Type[1];
            types[0] = typeof(Serviciu);

            XmlSerializer xs = new XmlSerializer(typeof(List<Serviciu>), types);
            StreamWriter sw = new StreamWriter("servicii.xml");

            xs.Serialize(sw, servicii);

            sw.Close();
        }

        public void Init(Pachet pachet)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\labs\\lab-6\\POS\\app1\\Servicii.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/servicii/Serviciu");
            foreach (XmlNode nod in lista_noduri)
            {

                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;

                Serviciu serv = new Serviciu(elemente.Count + 1, nume, codIntern, pret, categorie);// think about another id not related to elemente.Count same in PacheteMgr

                pachet.Add_element(serv);
            }
        }

        public void AfisareServicii()
        {
            foreach (ProdusAbstract serviciu in elemente)
            {
                Console.WriteLine(serviciu.Descriere());
            }
        }
    }
}

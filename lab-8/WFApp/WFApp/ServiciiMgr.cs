using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            doc.Load("D:\\Anul II\\OOP\\labs\\lab-6\\POS\\app1\\Servicii.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/servicii/Serviciu");

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

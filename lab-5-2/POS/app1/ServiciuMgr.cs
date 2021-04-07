using entitati;
using System;
using System.Linq;
using System.Xml;

namespace app1

{
    public class ServiciuMgr : ProdusAbstractMgr
    {
        public void AdaugareServicii(Serviciu serv)
        {
            //bool exist = produseServicii.Any(item => item.Nume == serv.Nume && item.CodIntern == serv.CodIntern && item.Pret == serv.Pret && item.Categorie == serv.Categorie);

            bool exist = false;
            foreach (ProdusAbstract obj in elemente)
            {
                if (obj.Id.Equals(serv.Id) && obj.Nume.Equals(serv.Nume) && obj.CodIntern.Equals(serv.CodIntern) && obj.Pret.Equals(serv.Pret) && obj.Categorie.Equals(serv.Categorie))
                {
                    exist = true;
                }
            }

            if (exist)
                {
                    Console.WriteLine("Serviciul exista deja!");
                }
                else
                {
                    elemente.Insereaza(serv);
                    Console.WriteLine("Serviciu adaugat!");
                }
        }

        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\labs\\lab-5-2\\POS\\app1\\Servicii.xml");
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

        public void AfisareServicii()
        {
            foreach (ProdusAbstract serviciu in elemente)
            {
                Console.WriteLine(serviciu.Descriere());
            }
        }
    }
}

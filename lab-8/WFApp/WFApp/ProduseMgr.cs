using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using entitati;

namespace WFApp
{
    public class ProduseMgr : ProdusAbstractMgr
    {
        public void AdaugareProduse(Produs prod)
        {
            bool exist = elemente.Any(item => item.Nume == prod.Nume && item.CodIntern == prod.CodIntern && item.Pret == prod.Pret && item.Categorie == prod.Categorie);

            if (exist)
            {
                Console.WriteLine("Produs exista deja!");
            }
            else
            {
                elemente.Add(prod);
                Console.WriteLine("Produs adaugat!");
            }
        }
        //string nume =  extboxNume.Text;
        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\labs\\lab-6\\POS\\app1\\Produse.xml");

            XmlNodeList lista_noduri = doc.SelectNodes("/produse/Produs");
            foreach (XmlNode nod in lista_noduri)
            {

                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;
                string producator = nod["Producator"].InnerText;

                Produs prod = new Produs(elemente.Count + 1, nume, codIntern, pret, categorie, producator);

                AdaugareProduse(prod);
            }
        }

        public void Init(Pachet pachet)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\labs\\lab-6\\POS\\app1\\Produse.xml");

            XmlNodeList lista_noduri = doc.SelectNodes("/produse/Produs");
            foreach (XmlNode nod in lista_noduri)
            {

                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;
                string producator = nod["Producator"].InnerText;

                Produs prod = new Produs(elemente.Count + 1, nume, codIntern, pret, categorie, producator);

                pachet.Add_element(prod);
            }
        }

        public void AfisareProduse()
        {
            foreach (ProdusAbstract produs in elemente)
            {
                Console.WriteLine(produs.Descriere());
            }
        }
    }
}

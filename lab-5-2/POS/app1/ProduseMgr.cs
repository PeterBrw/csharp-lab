﻿using entitati;
using System;
using System.Linq;
using System.Xml;

namespace app1
{
    public class ProduseMgr : ProdusAbstractMgr
    {
        public void AdaugareProduse (Produs prod)
        {
            //bool exist = produseServicii.Any(item => item.Nume == prod.Nume && item.CodIntern == prod.CodIntern && item.Pret == prod.Pret && item.Categorie == prod.Categorie ); 
            bool exist = false;
            foreach (ProdusAbstract obj in elemente)
            {
                if (obj.Nume.Equals(prod.Nume) && obj.CodIntern.Equals(prod.CodIntern) && obj.Pret.Equals(prod.Pret) && obj.Categorie.Equals(prod.Categorie)) 
                {
                    exist = true;
                }
            }

            if (exist)
                {
                    Console.WriteLine("Produs exista deja!");
                }
                else
                {
                    elemente.Insereaza(prod);
                    Console.WriteLine("Produs adaugat!");
                }
        }

        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\labs\\lab-5-2\\POS\\app1\\Produse.xml");

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

        public void AfisareProduse()
        {
            foreach (ProdusAbstract produs in elemente)
            {
                Console.WriteLine(produs.Descriere());
            }
        }
    }
}

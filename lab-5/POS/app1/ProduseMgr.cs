﻿using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace app1

{
    public class ProduseMgr : ProdusAbstractMgr
    {
        public void AdaugareProduse (Produs prod)
        {
                bool exist = produseServicii.Any(item => item.Nume == prod.Nume && item.CodIntern == prod.CodIntern && item.Pret == prod.Pret && item.Categorie == prod.Categorie ); 

                if (exist)
                {
                    Console.WriteLine("Produs exista deja!");
                }
                else
                {
                    produseServicii.Add(prod);
                    Console.WriteLine("Produs adaugat!");
                }
        }

        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\labs\\lab-5\\POS\\app1\\Produse.xml");

            XmlNodeList lista_noduri = doc.SelectNodes("/produse/Produs");
            foreach (XmlNode nod in lista_noduri)
            {

                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;
                string producator = nod["Producator"].InnerText;

                Produs prod = new Produs(produseServicii.Count + 1, nume, codIntern, pret, categorie, producator);

                AdaugareProduse(prod);
            }
        }

        public void AfisareProduse()
        {
            foreach (ProdusAbstract produs in produseServicii)
            {
                Console.WriteLine(produs.Descriere());
            }
        }
    }
}

using entitati;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WFApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<Produs> produse = new List<Produs>();

            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\csharp-lab\\lab-8\\WFApp\\WFApp\\bin\\Debug\\produse.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/ArrayOfProdus/Produs");

            foreach (XmlNode nod in lista_noduri)
            {

                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;
                string producator = nod["Producator"].InnerText;
                Produs prod= new Produs(rnd.Next(), nume, codIntern, pret, categorie, producator);

                produse.Add(prod);
            }

            string numeP = txtNume.Text;
            string codInternP = txtCodIntern.Text;
            int pretP = int.Parse(txtPret.Text);
            string categorieP = txtCategorie.Text;
            string producatorP = txtProducator.Text;

            Produs produs = new Produs(rnd.Next(), numeP, codInternP, pretP, categorieP, producatorP);

            produse.Add(produs);

            Type[] types = new Type[1];
            types[0] = typeof(Produs);

            XmlSerializer xs = new XmlSerializer(typeof(List<Produs>), types);
            StreamWriter sw = new StreamWriter("produse.xml");

            xs.Serialize(sw, produse);

            sw.Close();
        }
    }
}

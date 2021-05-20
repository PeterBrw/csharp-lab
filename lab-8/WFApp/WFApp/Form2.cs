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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void txtPret_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<Serviciu> servicii = new List<Serviciu>();

            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\csharp-lab\\lab-8\\WFApp\\WFApp\\bin\\Debug\\servicii.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/ArrayOfServiciu/Serviciu");

            foreach (XmlNode nod in lista_noduri)
            {

                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;

                Serviciu serv = new Serviciu(rnd.Next(), nume, codIntern, pret, categorie);
                servicii.Add(serv);
            }

            
            string numeS = txtNume.Text;
            string codInternS = txtCodIntern.Text;
            int pretS = int.Parse(txtPret.Text);
            string categorieS = txtCategorie.Text;
            int idS = rnd.Next();
            Serviciu serviciu = new Serviciu(idS, numeS, codInternS, pretS, categorieS);

            servicii.Add(serviciu);

            Type[] types = new Type[1];
            types[0] = typeof(Serviciu);
 
            XmlSerializer xs = new XmlSerializer(typeof(List<Serviciu>), types);
            StreamWriter sw = new StreamWriter("servicii.xml");

            xs.Serialize(sw, servicii);
            
            sw.Close();
        }
    }
}

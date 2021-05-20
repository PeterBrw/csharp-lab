using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WFApp
{
    public partial class Form5 : Form
    {
        DataTable dt = new DataTable();
        public Form5()
        {
            InitializeComponent();
            display();
        }

        public void display()
        {
            dt.Columns.Add("Nume");
            dt.Columns.Add("Cod Intern");
            dt.Columns.Add("Pret");
            dt.Columns.Add("Categorie");
            dt.Columns.Add("Producator");

            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Anul II\\OOP\\csharp-lab\\lab-8\\WFApp\\WFApp\\bin\\Debug\\produse.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/ArrayOfProdus/Produs");
            foreach (XmlNode nod in lista_noduri)
            {
                DataRow dr = dt.NewRow();
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;
                string producator = nod["Producator"].InnerText;
                dr[0] = nume;
                dr[1] = codIntern;
                dr[2] = pret;
                dr[3] = categorie;
                dr[4] = producator;

                dt.Rows.Add(dr);
            }

            dtDataGridView.DataSource = dt;

        }

        private void dtDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

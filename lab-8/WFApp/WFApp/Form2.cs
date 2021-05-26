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
using System.Xml.Serialization;

namespace WFApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridViewServicii.ColumnCount = 4;
            dataGridViewServicii.Columns[0].Name = "Nume";
            dataGridViewServicii.Columns[1].Name = "Cod Intern";
            dataGridViewServicii.Columns[2].Name = "Pret";
            dataGridViewServicii.Columns[3].Name = "Categorie";

            dataGridViewServicii.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewServicii.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServicii.MultiSelect = false;

            populateDataGrid();
        }

        private List<ProdusAbstract> servicii()
        {
            ServiciuMgr servicii = new ServiciuMgr();
            servicii.InitListafromXML();
            List<ProdusAbstract> services = servicii.elems();
            return services;
        }

        private void populateDataGrid()
        {
            var services = servicii();
            foreach (ProdusAbstract serv in services)
            {
                if (serv is Serviciu)
                {
                    dataGridViewServicii.Rows.Add(serv.Nume, serv.CodIntern, serv.Pret, serv.Categorie);
                }
            }
        }

        private void add(string nume, string codIntern, string pret, string categorie)
        {
            dataGridViewServicii.Rows.Add(nume, codIntern, pret, categorie);

            clearTxts();
        }

        private void clearTxts()
        {
            txtNumeServiciu.Text = "";
            txtCodInternServiciu.Text = "";
            txtPretServiciu.Text = "";
            txtCategorieServiciu.Text = "";
        }

        private void update()
        {
            dataGridViewServicii.SelectedRows[0].Cells[0].Value = txtNumeServiciu.Text;
            dataGridViewServicii.SelectedRows[0].Cells[1].Value = txtCodInternServiciu.Text;
            dataGridViewServicii.SelectedRows[0].Cells[2].Value = txtPretServiciu.Text;
            dataGridViewServicii.SelectedRows[0].Cells[3].Value = txtCategorieServiciu.Text;

            clearTxts();
        }

        private void delete()
        {

            if (dataGridViewServicii.RowCount <= 1 || dataGridViewServicii.SelectedRows[0].Cells[0].Value == null)
            {

            }
            else
            {
                if (MessageBox.Show("Vrei sa stergi Serviciul", "STERGERE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridViewServicii.SelectedRows[0].Index;

                    dataGridViewServicii.Rows.RemoveAt(index);

                    clearTxts();
                }
            }

        }

        private void btnAdaugaServiciu_Click(object sender, EventArgs e)
        {
            if (txtNumeServiciu.Text == "" || txtCodInternServiciu.Text == "" || txtPretServiciu.Text == "" || txtCategorieServiciu.Text == "")
            {

            }
            else
            {
                add(txtNumeServiciu.Text, txtCodInternServiciu.Text, txtPretServiciu.Text, txtCategorieServiciu.Text);
            }
        }

        private void btnModificaServiciu_Click(object sender, EventArgs e)
        {
            if (txtNumeServiciu.Text == "" || txtCodInternServiciu.Text == "" || txtPretServiciu.Text == "" || txtCategorieServiciu.Text == "")
            {

            }
            else
            {
                update();
            }
        }

        private void btnStergeServiciu_Click(object sender, EventArgs e)
        {
            delete();
            Refresh();
        }

        private void btnClearServiciu_Click(object sender, EventArgs e)
        {
            dataGridViewServicii.Rows.Clear();
        }

        private void dataGridViewServicii_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewServicii.SelectedRows[0].Cells[0].Value == null)
            {

            }
            else
            {
                txtNumeServiciu.Text = dataGridViewServicii.SelectedRows[0].Cells[0].Value.ToString();
                txtCodInternServiciu.Text = dataGridViewServicii.SelectedRows[0].Cells[1].Value.ToString();
                txtPretServiciu.Text = dataGridViewServicii.SelectedRows[0].Cells[2].Value.ToString();
                txtCategorieServiciu.Text = dataGridViewServicii.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void btnSalvareServiciu_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<Serviciu> serviciiDeSalvat = new List<Serviciu>();

            foreach (DataGridViewRow row in dataGridViewServicii.Rows)
            {
                string nume = row.Cells[0].Value == null ?
          string.Empty : row.Cells[0].Value.ToString();
                string codIntern = row.Cells[1].Value == null ?
          string.Empty : row.Cells[1].Value.ToString();
                int pret = row.Cells[2].Value == null ?
          0 : int.Parse(row.Cells[2].Value.ToString());
                string categorie = row.Cells[3].Value == null ?
          string.Empty : row.Cells[3].Value.ToString();
                int id = rnd.Next(1, 1000);

                if(nume == null || nume == "")
                {

                } else
                {
                    serviciiDeSalvat.Add(new Serviciu(id, nume, codIntern, pret, categorie));
                }
            }


            ServiciuMgr serv = new ServiciuMgr();
            serv.WriteListToXML(serviciiDeSalvat);
        }
    }
}

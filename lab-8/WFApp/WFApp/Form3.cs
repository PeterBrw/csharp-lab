using entitati;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dataGridViewProduse.ColumnCount = 5;
            dataGridViewProduse.Columns[0].Name = "Nume";
            dataGridViewProduse.Columns[1].Name = "Cod Intern";
            dataGridViewProduse.Columns[2].Name = "Pret";
            dataGridViewProduse.Columns[3].Name = "Categorie";
            dataGridViewProduse.Columns[4].Name = "Producator";

            dataGridViewProduse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewProduse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduse.MultiSelect = false;

            populateDataGrid();
        }

        private List<ProdusAbstract> produse()
        {
            ProduseMgr produse = new ProduseMgr();
            produse.InitListafromXML();
            List<ProdusAbstract> produces = produse.elems();
            return produces;
        }

        private void populateDataGrid()
        {
            var produces = produse();
            foreach (ProdusAbstract prod in produces)
            {
                if (prod is Produs)
                {
                    Produs prodC = (Produs)prod;
                    dataGridViewProduse.Rows.Add(prodC.Nume, prodC.CodIntern, prodC.Pret, prodC.Categorie, prodC.Producator);
                }
            }
        }

        private void add(string nume, string codIntern, string pret, string categorie, string producator)
        {
            dataGridViewProduse.Rows.Add(nume, codIntern, pret, categorie, producator);

            clearTxts();
        }

        private void clearTxts()
        {
            txtNumeProdus.Text = "";
            txtCodInternProdus.Text = "";
            txtPretProdus.Text = "";
            txtCategorieProdus.Text = "";
            txtProducatorProdus.Text = "";
        }

        private void update()
        {
            dataGridViewProduse.SelectedRows[0].Cells[0].Value = txtNumeProdus.Text;
            dataGridViewProduse.SelectedRows[0].Cells[1].Value = txtCodInternProdus.Text;
            dataGridViewProduse.SelectedRows[0].Cells[2].Value = txtPretProdus.Text;
            dataGridViewProduse.SelectedRows[0].Cells[3].Value = txtCategorieProdus.Text;
            dataGridViewProduse.SelectedRows[0].Cells[4].Value = txtProducatorProdus.Text;

            clearTxts();
        }

        private void delete()
        {

            if (dataGridViewProduse.RowCount <= 1 || dataGridViewProduse.SelectedRows[0].Cells[0].Value == null)
            {

            }
            else
            {
                if (MessageBox.Show("Vrei sa stergi Produsul", "STERGERE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridViewProduse.SelectedRows[0].Index;

                    dataGridViewProduse.Rows.RemoveAt(index);

                    clearTxts();
                }
            }

        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            if (txtNumeProdus.Text == "" || txtCodInternProdus.Text == "" || txtPretProdus.Text == "" || txtCategorieProdus.Text == "" || txtProducatorProdus.Text == "")
            {

            }
            else
            {
                add(txtNumeProdus.Text, txtCodInternProdus.Text, txtPretProdus.Text, txtCategorieProdus.Text, txtProducatorProdus.Text);
            }
        }

        private void btnModificaProdus_Click(object sender, EventArgs e)
        {
            if (txtNumeProdus.Text == "" || txtCodInternProdus.Text == "" || txtPretProdus.Text == "" || txtCategorieProdus.Text == "" || txtProducatorProdus.Text == "")
            {

            }
            else
            {
                update();
            }

        }

        private void btnStergereProdus_Click(object sender, EventArgs e)
        {
            delete();
            Refresh();
        }

        private void btnClearProdus_Click(object sender, EventArgs e)
        {
            dataGridViewProduse.Rows.Clear();
        }

         private void dataGridProduse_MouseClick(object sender, MouseEventArgs e)
        {
            if(dataGridViewProduse.SelectedRows[0].Cells[0].Value == null)
            {

            }
            else
            {
                txtNumeProdus.Text = dataGridViewProduse.SelectedRows[0].Cells[0].Value.ToString();
                txtCodInternProdus.Text = dataGridViewProduse.SelectedRows[0].Cells[1].Value.ToString();
                txtPretProdus.Text = dataGridViewProduse.SelectedRows[0].Cells[2].Value.ToString();
                txtCategorieProdus.Text = dataGridViewProduse.SelectedRows[0].Cells[3].Value.ToString();
                txtProducatorProdus.Text = dataGridViewProduse.SelectedRows[0].Cells[4].Value.ToString();
            }

        }

        private void btnSalvareProdus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<Produs> produseDeSalvat = new List<Produs>();

            foreach (DataGridViewRow row in dataGridViewProduse.Rows)
            {
                string nume = row.Cells[0].Value == null ?
          string.Empty : row.Cells[0].Value.ToString();
                string codIntern = row.Cells[1].Value == null ?
          string.Empty : row.Cells[1].Value.ToString();
                int pret = row.Cells[2].Value == null ?
          0 : int.Parse(row.Cells[2].Value.ToString());
                string categorie = row.Cells[3].Value == null ?
          string.Empty : row.Cells[3].Value.ToString();
                string producator = row.Cells[3].Value == null ?
          string.Empty : row.Cells[4].Value.ToString();
                int id = rnd.Next(1, 1000);

                if (nume == null || nume == "")
                {

                }
                else
                {
                    produseDeSalvat.Add(new Produs(id, nume, codIntern, pret, categorie, producator));
                }
            }


            ProduseMgr prod = new ProduseMgr();
            prod.WriteListToXML(produseDeSalvat);
        } 
    }
}

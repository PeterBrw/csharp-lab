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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butMyFom_Click(object sender, EventArgs e)
        {
            MyForm aform = new MyForm();
            aform.Load += new EventHandler(MyForm_Load2);
            aform.Show();
        }

        private void MyForm_Load2(object sender, EventArgs e)
        {
            MessageBox.Show("Se va afisa fereastra MyFOrm!!!");
        }

        private void but_schimba_Click(object sender, EventArgs e)
        {
            this.Text = "Fereastra modificata la run-time!";
        }
    }
}

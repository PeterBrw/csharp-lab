
namespace WFApp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNume = new System.Windows.Forms.Label();
            this.lblCodIntern = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblProducator = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCodIntern = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtProducator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(279, 94);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblCodIntern
            // 
            this.lblCodIntern.AutoSize = true;
            this.lblCodIntern.Location = new System.Drawing.Point(279, 129);
            this.lblCodIntern.Name = "lblCodIntern";
            this.lblCodIntern.Size = new System.Drawing.Size(56, 13);
            this.lblCodIntern.TabIndex = 1;
            this.lblCodIntern.Text = "Cod Intern";
            this.lblCodIntern.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(279, 159);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(26, 13);
            this.lblPret.TabIndex = 2;
            this.lblPret.Text = "Pret";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(276, 197);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 3;
            this.lblCategorie.Text = "Categorie";
            // 
            // lblProducator
            // 
            this.lblProducator.AutoSize = true;
            this.lblProducator.Location = new System.Drawing.Point(276, 230);
            this.lblProducator.Name = "lblProducator";
            this.lblProducator.Size = new System.Drawing.Size(59, 13);
            this.lblProducator.TabIndex = 4;
            this.lblProducator.Text = "Producator";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(365, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(365, 94);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 6;
            // 
            // txtCodIntern
            // 
            this.txtCodIntern.Location = new System.Drawing.Point(365, 129);
            this.txtCodIntern.Name = "txtCodIntern";
            this.txtCodIntern.Size = new System.Drawing.Size(100, 20);
            this.txtCodIntern.TabIndex = 7;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(365, 159);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 20);
            this.txtPret.TabIndex = 8;
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(365, 197);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(100, 20);
            this.txtCategorie.TabIndex = 9;
            // 
            // txtProducator
            // 
            this.txtProducator.Location = new System.Drawing.Point(365, 230);
            this.txtProducator.Name = "txtProducator";
            this.txtProducator.Size = new System.Drawing.Size(100, 20);
            this.txtProducator.TabIndex = 10;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProducator);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtCodIntern);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblProducator);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblCodIntern);
            this.Controls.Add(this.lblNume);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblCodIntern;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblProducator;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCodIntern;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtProducator;
    }
}

namespace WFApp
{
    partial class Form2
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtCodIntern = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lablCategorie = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblCodIntern = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(367, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(367, 215);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(100, 20);
            this.txtCategorie.TabIndex = 16;
            this.txtCategorie.TextChanged += new System.EventHandler(this.txtCategorie_TextChanged);
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(367, 180);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 20);
            this.txtPret.TabIndex = 15;
            this.txtPret.TextChanged += new System.EventHandler(this.txtPret_TextChanged);
            // 
            // txtCodIntern
            // 
            this.txtCodIntern.Location = new System.Drawing.Point(367, 142);
            this.txtCodIntern.Name = "txtCodIntern";
            this.txtCodIntern.Size = new System.Drawing.Size(100, 20);
            this.txtCodIntern.TabIndex = 14;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(367, 108);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 13;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // lablCategorie
            // 
            this.lablCategorie.AutoSize = true;
            this.lablCategorie.Location = new System.Drawing.Point(284, 215);
            this.lablCategorie.Name = "lablCategorie";
            this.lablCategorie.Size = new System.Drawing.Size(52, 13);
            this.lablCategorie.TabIndex = 12;
            this.lablCategorie.Text = "Categorie";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(284, 180);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(26, 13);
            this.lblPret.TabIndex = 11;
            this.lblPret.Text = "Pret";
            // 
            // lblCodIntern
            // 
            this.lblCodIntern.AutoSize = true;
            this.lblCodIntern.Location = new System.Drawing.Point(284, 142);
            this.lblCodIntern.Name = "lblCodIntern";
            this.lblCodIntern.Size = new System.Drawing.Size(56, 13);
            this.lblCodIntern.TabIndex = 10;
            this.lblCodIntern.Text = "Cod Intern";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(284, 111);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 9;
            this.lblNume.Text = "Nume";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtCodIntern);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lablCategorie);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblCodIntern);
            this.Controls.Add(this.lblNume);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtCodIntern;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lablCategorie;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblCodIntern;
        private System.Windows.Forms.Label lblNume;
    }
}
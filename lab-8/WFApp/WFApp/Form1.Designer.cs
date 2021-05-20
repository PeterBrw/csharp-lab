
namespace WFApp
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnAfisareServicii = new System.Windows.Forms.Button();
            this.btnAdaugareServicii = new System.Windows.Forms.Button();
            this.btnAfisareProduse = new System.Windows.Forms.Button();
            this.btnAdaugareProduse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfisareServicii
            // 
            this.btnAfisareServicii.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAfisareServicii.Location = new System.Drawing.Point(64, 81);
            this.btnAfisareServicii.Name = "btnAfisareServicii";
            this.btnAfisareServicii.Size = new System.Drawing.Size(177, 23);
            this.btnAfisareServicii.TabIndex = 9;
            this.btnAfisareServicii.Text = "Afisare Servicii";
            this.btnAfisareServicii.UseVisualStyleBackColor = true;
            this.btnAfisareServicii.Click += new System.EventHandler(this.btnAfisareServicii_Click);
            // 
            // btnAdaugareServicii
            // 
            this.btnAdaugareServicii.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAdaugareServicii.Location = new System.Drawing.Point(64, 145);
            this.btnAdaugareServicii.Name = "btnAdaugareServicii";
            this.btnAdaugareServicii.Size = new System.Drawing.Size(177, 23);
            this.btnAdaugareServicii.TabIndex = 10;
            this.btnAdaugareServicii.Text = "Adaugare Servicii";
            this.btnAdaugareServicii.UseVisualStyleBackColor = true;
            this.btnAdaugareServicii.Click += new System.EventHandler(this.btnAdaugareServicii_Click);
            // 
            // btnAfisareProduse
            // 
            this.btnAfisareProduse.Location = new System.Drawing.Point(286, 81);
            this.btnAfisareProduse.Name = "btnAfisareProduse";
            this.btnAfisareProduse.Size = new System.Drawing.Size(162, 23);
            this.btnAfisareProduse.TabIndex = 11;
            this.btnAfisareProduse.Text = "Afisare Produse";
            this.btnAfisareProduse.UseVisualStyleBackColor = true;
            this.btnAfisareProduse.Click += new System.EventHandler(this.btnAfisareProduse_Click);
            // 
            // btnAdaugareProduse
            // 
            this.btnAdaugareProduse.Location = new System.Drawing.Point(286, 145);
            this.btnAdaugareProduse.Name = "btnAdaugareProduse";
            this.btnAdaugareProduse.Size = new System.Drawing.Size(162, 23);
            this.btnAdaugareProduse.TabIndex = 12;
            this.btnAdaugareProduse.Text = "Adaugare Produse";
            this.btnAdaugareProduse.UseVisualStyleBackColor = true;
            this.btnAdaugareProduse.Click += new System.EventHandler(this.btnAdaugareProduse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 698);
            this.Controls.Add(this.btnAdaugareProduse);
            this.Controls.Add(this.btnAfisareProduse);
            this.Controls.Add(this.btnAdaugareServicii);
            this.Controls.Add(this.btnAfisareServicii);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnAfisareServicii;
        private System.Windows.Forms.Button btnAdaugareServicii;
        private System.Windows.Forms.Button btnAfisareProduse;
        private System.Windows.Forms.Button btnAdaugareProduse;
    }
}


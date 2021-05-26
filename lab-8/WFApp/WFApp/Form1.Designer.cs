
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
            this.btnServicii = new System.Windows.Forms.Button();
            this.btnProduse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServicii
            // 
            this.btnServicii.Location = new System.Drawing.Point(232, 292);
            this.btnServicii.Name = "btnServicii";
            this.btnServicii.Size = new System.Drawing.Size(137, 47);
            this.btnServicii.TabIndex = 0;
            this.btnServicii.Text = "Servicii";
            this.btnServicii.UseVisualStyleBackColor = true;
            this.btnServicii.Click += new System.EventHandler(this.btnServicii_Click);
            // 
            // btnProduse
            // 
            this.btnProduse.Location = new System.Drawing.Point(505, 292);
            this.btnProduse.Name = "btnProduse";
            this.btnProduse.Size = new System.Drawing.Size(137, 47);
            this.btnProduse.TabIndex = 1;
            this.btnProduse.Text = "Produse";
            this.btnProduse.UseVisualStyleBackColor = true;
            this.btnProduse.Click += new System.EventHandler(this.btnProduse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 698);
            this.Controls.Add(this.btnProduse);
            this.Controls.Add(this.btnServicii);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnServicii;
        private System.Windows.Forms.Button btnProduse;
    }
}


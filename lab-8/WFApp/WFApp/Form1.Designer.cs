
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
            this.butMyFom = new System.Windows.Forms.Button();
            this.but_schimba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butMyFom
            // 
            this.butMyFom.Location = new System.Drawing.Point(327, 298);
            this.butMyFom.Name = "butMyFom";
            this.butMyFom.Size = new System.Drawing.Size(193, 65);
            this.butMyFom.TabIndex = 0;
            this.butMyFom.Text = "Catre MyForm";
            this.butMyFom.UseVisualStyleBackColor = true;
            this.butMyFom.Click += new System.EventHandler(this.butMyFom_Click);
            // 
            // but_schimba
            // 
            this.but_schimba.Location = new System.Drawing.Point(342, 476);
            this.but_schimba.Name = "but_schimba";
            this.but_schimba.Size = new System.Drawing.Size(178, 81);
            this.but_schimba.TabIndex = 1;
            this.but_schimba.Text = "Schimba";
            this.but_schimba.UseVisualStyleBackColor = true;
            this.but_schimba.Click += new System.EventHandler(this.but_schimba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 698);
            this.Controls.Add(this.but_schimba);
            this.Controls.Add(this.butMyFom);
            this.Name = "Form1";
            this.Text = "Fereastra principala";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butMyFom;
        private System.Windows.Forms.Button but_schimba;
    }
}


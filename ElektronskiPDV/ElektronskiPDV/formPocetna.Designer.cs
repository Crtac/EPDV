namespace ElektronskiPDV
{
    partial class formPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPocetna));
            this.btnKreirajEPDV = new System.Windows.Forms.Button();
            this.btnPregledKIF = new System.Windows.Forms.Button();
            this.btnPregledKUF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKreirajEPDV
            // 
            this.btnKreirajEPDV.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnKreirajEPDV.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajEPDV.Location = new System.Drawing.Point(12, 12);
            this.btnKreirajEPDV.Name = "btnKreirajEPDV";
            this.btnKreirajEPDV.Size = new System.Drawing.Size(447, 86);
            this.btnKreirajEPDV.TabIndex = 0;
            this.btnKreirajEPDV.Text = "Kreiranje EPDV datoteka za period";
            this.btnKreirajEPDV.UseVisualStyleBackColor = false;
            this.btnKreirajEPDV.Click += new System.EventHandler(this.btnKreirajEPDV_Click);
            // 
            // btnPregledKIF
            // 
            this.btnPregledKIF.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnPregledKIF.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledKIF.Location = new System.Drawing.Point(12, 104);
            this.btnPregledKIF.Name = "btnPregledKIF";
            this.btnPregledKIF.Size = new System.Drawing.Size(447, 86);
            this.btnPregledKIF.TabIndex = 1;
            this.btnPregledKIF.Text = "Pregled KIF-a";
            this.btnPregledKIF.UseVisualStyleBackColor = false;
            this.btnPregledKIF.Click += new System.EventHandler(this.btnPregledKIF_Click);
            // 
            // btnPregledKUF
            // 
            this.btnPregledKUF.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnPregledKUF.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledKUF.Location = new System.Drawing.Point(12, 196);
            this.btnPregledKUF.Name = "btnPregledKUF";
            this.btnPregledKUF.Size = new System.Drawing.Size(447, 86);
            this.btnPregledKUF.TabIndex = 2;
            this.btnPregledKUF.Text = "Pregled KUF-a";
            this.btnPregledKUF.UseVisualStyleBackColor = false;
            this.btnPregledKUF.Click += new System.EventHandler(this.btnPregledKUF_Click);
            // 
            // formPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(471, 295);
            this.Controls.Add(this.btnPregledKUF);
            this.Controls.Add(this.btnPregledKIF);
            this.Controls.Add(this.btnKreirajEPDV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPDV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKreirajEPDV;
        private System.Windows.Forms.Button btnPregledKIF;
        private System.Windows.Forms.Button btnPregledKUF;
    }
}


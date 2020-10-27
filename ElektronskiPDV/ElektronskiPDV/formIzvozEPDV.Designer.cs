namespace ElektronskiPDV
{
    partial class formIzvozEPDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIzvozEPDV));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPeriod = new System.Windows.Forms.DateTimePicker();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLokacija = new System.Windows.Forms.Button();
            this.btnIzvrsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Period za elektronsku evidenciju:";
            // 
            // dtpPeriod
            // 
            this.dtpPeriod.CustomFormat = "MMMM, yyyy";
            this.dtpPeriod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriod.Location = new System.Drawing.Point(16, 59);
            this.dtpPeriod.Name = "dtpPeriod";
            this.dtpPeriod.ShowUpDown = true;
            this.dtpPeriod.Size = new System.Drawing.Size(260, 30);
            this.dtpPeriod.TabIndex = 1;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLokacija.Location = new System.Drawing.Point(16, 141);
            this.txtLokacija.Multiline = true;
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(352, 83);
            this.txtLokacija.TabIndex = 2;
            this.txtLokacija.Text = "C:\\EPDV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lokacija:";
            // 
            // btnLokacija
            // 
            this.btnLokacija.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLokacija.Location = new System.Drawing.Point(374, 140);
            this.btnLokacija.Name = "btnLokacija";
            this.btnLokacija.Size = new System.Drawing.Size(55, 84);
            this.btnLokacija.TabIndex = 4;
            this.btnLokacija.Text = "...";
            this.btnLokacija.UseVisualStyleBackColor = true;
            this.btnLokacija.Click += new System.EventHandler(this.btnLokacija_Click);
            // 
            // btnIzvrsi
            // 
            this.btnIzvrsi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvrsi.Location = new System.Drawing.Point(16, 243);
            this.btnIzvrsi.Name = "btnIzvrsi";
            this.btnIzvrsi.Size = new System.Drawing.Size(413, 83);
            this.btnIzvrsi.TabIndex = 5;
            this.btnIzvrsi.Text = "Izvrši";
            this.btnIzvrsi.UseVisualStyleBackColor = true;
            this.btnIzvrsi.Click += new System.EventHandler(this.btnIzvrsi_Click);
            // 
            // formIzvozEPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(451, 346);
            this.Controls.Add(this.btnIzvrsi);
            this.Controls.Add(this.btnLokacija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.dtpPeriod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formIzvozEPDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "izvozEPDV";
            this.Load += new System.EventHandler(this.formIzvozEPDV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPeriod;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLokacija;
        private System.Windows.Forms.Button btnIzvrsi;
    }
}
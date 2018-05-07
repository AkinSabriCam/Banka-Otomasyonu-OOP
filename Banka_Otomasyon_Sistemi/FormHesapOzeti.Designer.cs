namespace Banka_Otomasyon_Sistemi
{
    partial class FormHesapOzeti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHesapOzeti));
            this.lblMusteriNoHO = new System.Windows.Forms.Label();
            this.btnGörüntüleHO = new System.Windows.Forms.Button();
            this.lblHesapNoHO = new System.Windows.Forms.Label();
            this.txtHesapNoHO = new System.Windows.Forms.TextBox();
            this.txtListeHO = new System.Windows.Forms.TextBox();
            this.ppdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblMusteriNoHO
            // 
            this.lblMusteriNoHO.AutoSize = true;
            this.lblMusteriNoHO.Location = new System.Drawing.Point(25, 35);
            this.lblMusteriNoHO.Name = "lblMusteriNoHO";
            this.lblMusteriNoHO.Size = new System.Drawing.Size(180, 24);
            this.lblMusteriNoHO.TabIndex = 0;
            this.lblMusteriNoHO.Text = "Tarih Aralığı Seçiniz :";
            // 
            // btnGörüntüleHO
            // 
            this.btnGörüntüleHO.Location = new System.Drawing.Point(526, 92);
            this.btnGörüntüleHO.Name = "btnGörüntüleHO";
            this.btnGörüntüleHO.Size = new System.Drawing.Size(169, 37);
            this.btnGörüntüleHO.TabIndex = 1;
            this.btnGörüntüleHO.Text = "Görüntüle";
            this.btnGörüntüleHO.UseVisualStyleBackColor = true;
            this.btnGörüntüleHO.Click += new System.EventHandler(this.btnGörüntüleHO_Click);
            // 
            // lblHesapNoHO
            // 
            this.lblHesapNoHO.AutoSize = true;
            this.lblHesapNoHO.Location = new System.Drawing.Point(49, 98);
            this.lblHesapNoHO.Name = "lblHesapNoHO";
            this.lblHesapNoHO.Size = new System.Drawing.Size(156, 24);
            this.lblHesapNoHO.TabIndex = 0;
            this.lblHesapNoHO.Text = "Hesap Numarası: ";
            // 
            // txtHesapNoHO
            // 
            this.txtHesapNoHO.Location = new System.Drawing.Point(220, 95);
            this.txtHesapNoHO.Name = "txtHesapNoHO";
            this.txtHesapNoHO.Size = new System.Drawing.Size(266, 32);
            this.txtHesapNoHO.TabIndex = 2;
            // 
            // txtListeHO
            // 
            this.txtListeHO.Location = new System.Drawing.Point(39, 157);
            this.txtListeHO.Multiline = true;
            this.txtListeHO.Name = "txtListeHO";
            this.txtListeHO.Size = new System.Drawing.Size(826, 233);
            this.txtListeHO.TabIndex = 4;
            // 
            // ppdDialog
            // 
            this.ppdDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdDialog.Document = this.pdYazici;
            this.ppdDialog.Enabled = true;
            this.ppdDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdDialog.Icon")));
            this.ppdDialog.Name = "ppdDialog";
            this.ppdDialog.Visible = false;
            
            // 
            // pdYazici
            // 
            
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CustomFormat = "dd.MM.yyyy";
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangic.Location = new System.Drawing.Point(220, 35);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(266, 32);
            this.dtpBaslangic.TabIndex = 5;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // dtpBitis
            // 
            this.dtpBitis.CustomFormat = " dd.MM.yyyy";
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitis.Location = new System.Drawing.Point(526, 35);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(293, 32);
            this.dtpBitis.TabIndex = 6;
            // 
            // FormHesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1567, 684);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.txtListeHO);
            this.Controls.Add(this.txtHesapNoHO);
            this.Controls.Add(this.lblHesapNoHO);
            this.Controls.Add(this.btnGörüntüleHO);
            this.Controls.Add(this.lblMusteriNoHO);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHesapOzeti";
            this.Text = "Hesap Özeti";
            this.Load += new System.EventHandler(this.FormHesapOzeti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriNoHO;
        private System.Windows.Forms.Button btnGörüntüleHO;
        private System.Windows.Forms.Label lblHesapNoHO;
        private System.Windows.Forms.TextBox txtHesapNoHO;
        private System.Windows.Forms.TextBox txtListeHO;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
        private System.Drawing.Printing.PrintDocument pdYazici;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
    }
}
namespace Banka_Otomasyon_Sistemi
{
    partial class FormParaİşlemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriNoPI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTutarPI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHesapNoPI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdCekme = new System.Windows.Forms.RadioButton();
            this.rdYatirma = new System.Windows.Forms.RadioButton();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtListePI = new System.Windows.Forms.TextBox();
            this.rdHavale = new System.Windows.Forms.RadioButton();
            this.txtMusteriNo2PI = new System.Windows.Forms.TextBox();
            this.txtHesapNo2PI = new System.Windows.Forms.TextBox();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.lblHesNo = new System.Windows.Forms.Label();
            this.btnBul2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Numarası :";
            // 
            // txtMusteriNoPI
            // 
            this.txtMusteriNoPI.Location = new System.Drawing.Point(205, 37);
            this.txtMusteriNoPI.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriNoPI.Name = "txtMusteriNoPI";
            this.txtMusteriNoPI.Size = new System.Drawing.Size(249, 32);
            this.txtMusteriNoPI.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tutar :";
            // 
            // txtTutarPI
            // 
            this.txtTutarPI.Location = new System.Drawing.Point(205, 399);
            this.txtTutarPI.Margin = new System.Windows.Forms.Padding(4);
            this.txtTutarPI.Name = "txtTutarPI";
            this.txtTutarPI.Size = new System.Drawing.Size(249, 32);
            this.txtTutarPI.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hesap Numarası :";
            // 
            // txtHesapNoPI
            // 
            this.txtHesapNoPI.Location = new System.Drawing.Point(205, 342);
            this.txtHesapNoPI.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapNoPI.Name = "txtHesapNoPI";
            this.txtHesapNoPI.Size = new System.Drawing.Size(249, 32);
            this.txtHesapNoPI.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 471);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "İşlem : ";
            // 
            // rdCekme
            // 
            this.rdCekme.AutoSize = true;
            this.rdCekme.Location = new System.Drawing.Point(205, 469);
            this.rdCekme.Margin = new System.Windows.Forms.Padding(4);
            this.rdCekme.Name = "rdCekme";
            this.rdCekme.Size = new System.Drawing.Size(129, 28);
            this.rdCekme.TabIndex = 2;
            this.rdCekme.TabStop = true;
            this.rdCekme.Text = "Para Çekme";
            this.rdCekme.UseVisualStyleBackColor = true;
            // 
            // rdYatirma
            // 
            this.rdYatirma.AutoSize = true;
            this.rdYatirma.Location = new System.Drawing.Point(345, 469);
            this.rdYatirma.Margin = new System.Windows.Forms.Padding(4);
            this.rdYatirma.Name = "rdYatirma";
            this.rdYatirma.Size = new System.Drawing.Size(136, 28);
            this.rdYatirma.TabIndex = 2;
            this.rdYatirma.TabStop = true;
            this.rdYatirma.Text = "Para Yatırma";
            this.rdYatirma.UseVisualStyleBackColor = true;
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(387, 643);
            this.btnTamamla.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(208, 77);
            this.btnTamamla.TabIndex = 3;
            this.btnTamamla.Text = "İŞLEMİ TAMAMLA";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Location = new System.Drawing.Point(487, 28);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(108, 42);
            this.btnBul.TabIndex = 4;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtListePI
            // 
            this.txtListePI.Location = new System.Drawing.Point(31, 95);
            this.txtListePI.Multiline = true;
            this.txtListePI.Name = "txtListePI";
            this.txtListePI.Size = new System.Drawing.Size(564, 223);
            this.txtListePI.TabIndex = 5;
            // 
            // rdHavale
            // 
            this.rdHavale.AutoSize = true;
            this.rdHavale.Location = new System.Drawing.Point(487, 469);
            this.rdHavale.Name = "rdHavale";
            this.rdHavale.Size = new System.Drawing.Size(129, 28);
            this.rdHavale.TabIndex = 6;
            this.rdHavale.TabStop = true;
            this.rdHavale.Text = "Para Havale";
            this.rdHavale.UseVisualStyleBackColor = true;
            this.rdHavale.CheckedChanged += new System.EventHandler(this.rdHavale_CheckedChanged);
            // 
            // txtMusteriNo2PI
            // 
            this.txtMusteriNo2PI.Enabled = false;
            this.txtMusteriNo2PI.Location = new System.Drawing.Point(205, 530);
            this.txtMusteriNo2PI.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriNo2PI.Name = "txtMusteriNo2PI";
            this.txtMusteriNo2PI.Size = new System.Drawing.Size(249, 32);
            this.txtMusteriNo2PI.TabIndex = 1;
            // 
            // txtHesapNo2PI
            // 
            this.txtHesapNo2PI.Enabled = false;
            this.txtHesapNo2PI.Location = new System.Drawing.Point(205, 581);
            this.txtHesapNo2PI.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapNo2PI.Name = "txtHesapNo2PI";
            this.txtHesapNo2PI.Size = new System.Drawing.Size(249, 32);
            this.txtHesapNo2PI.TabIndex = 1;
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Enabled = false;
            this.lblMusteriNo.Location = new System.Drawing.Point(51, 533);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(170, 24);
            this.lblMusteriNo.TabIndex = 7;
            this.lblMusteriNo.Text = "Müşteri Numarası :";
            // 
            // lblHesNo
            // 
            this.lblHesNo.AutoSize = true;
            this.lblHesNo.Enabled = false;
            this.lblHesNo.Location = new System.Drawing.Point(59, 584);
            this.lblHesNo.Name = "lblHesNo";
            this.lblHesNo.Size = new System.Drawing.Size(156, 24);
            this.lblHesNo.TabIndex = 8;
            this.lblHesNo.Text = "Hesap Numarası :";
            // 
            // btnBul2
            // 
            this.btnBul2.Enabled = false;
            this.btnBul2.Location = new System.Drawing.Point(468, 526);
            this.btnBul2.Name = "btnBul2";
            this.btnBul2.Size = new System.Drawing.Size(92, 32);
            this.btnBul2.TabIndex = 9;
            this.btnBul2.Text = "BUL";
            this.btnBul2.UseVisualStyleBackColor = true;
            this.btnBul2.Click += new System.EventHandler(this.btnBul2_Click);
            // 
            // FormParaİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 722);
            this.Controls.Add(this.btnBul2);
            this.Controls.Add(this.lblHesNo);
            this.Controls.Add(this.lblMusteriNo);
            this.Controls.Add(this.rdHavale);
            this.Controls.Add(this.txtListePI);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.rdYatirma);
            this.Controls.Add(this.rdCekme);
            this.Controls.Add(this.txtHesapNoPI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriNo2PI);
            this.Controls.Add(this.txtHesapNo2PI);
            this.Controls.Add(this.txtTutarPI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriNoPI);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormParaİşlemleri";
            this.Text = "PARA İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FormParaİşlemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriNoPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTutarPI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHesapNoPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdCekme;
        private System.Windows.Forms.RadioButton rdYatirma;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtListePI;
        private System.Windows.Forms.RadioButton rdHavale;
        private System.Windows.Forms.TextBox txtMusteriNo2PI;
        private System.Windows.Forms.TextBox txtHesapNo2PI;
        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblHesNo;
        private System.Windows.Forms.Button btnBul2;
    }
}
namespace Banka_Otomasyon_Sistemi
{
    partial class FormMusteriEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblMno = new System.Windows.Forms.Label();
            this.lblmusterino = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdBireysel = new System.Windows.Forms.RadioButton();
            this.rdTicari = new System.Windows.Forms.RadioButton();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // txtTckn
            // 
            this.txtTckn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTckn.Location = new System.Drawing.Point(137, 25);
            this.txtTckn.Margin = new System.Windows.Forms.Padding(2);
            this.txtTckn.MaxLength = 11;
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(182, 32);
            this.txtTckn.TabIndex = 3;
            this.txtTckn.TextChanged += new System.EventHandler(this.txtTckn_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(137, 64);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(182, 32);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(137, 103);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(182, 32);
            this.txtSoyad.TabIndex = 5;
            // 
            // lblMno
            // 
            this.lblMno.AutoSize = true;
            this.lblMno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMno.Location = new System.Drawing.Point(15, 252);
            this.lblMno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMno.Name = "lblMno";
            this.lblMno.Size = new System.Drawing.Size(109, 24);
            this.lblMno.TabIndex = 6;
            this.lblMno.Text = "Müşteri No:";
            this.lblMno.Visible = false;
            // 
            // lblmusterino
            // 
            this.lblmusterino.AutoSize = true;
            this.lblmusterino.BackColor = System.Drawing.Color.Silver;
            this.lblmusterino.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmusterino.Location = new System.Drawing.Point(139, 249);
            this.lblmusterino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmusterino.Name = "lblmusterino";
            this.lblmusterino.Size = new System.Drawing.Size(117, 29);
            this.lblmusterino.TabIndex = 7;
            this.lblmusterino.Text = "müşterino";
            this.lblmusterino.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Müşteri Tipi:";
            // 
            // rdBireysel
            // 
            this.rdBireysel.AutoSize = true;
            this.rdBireysel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBireysel.Location = new System.Drawing.Point(137, 146);
            this.rdBireysel.Margin = new System.Windows.Forms.Padding(2);
            this.rdBireysel.Name = "rdBireysel";
            this.rdBireysel.Size = new System.Drawing.Size(96, 28);
            this.rdBireysel.TabIndex = 9;
            this.rdBireysel.TabStop = true;
            this.rdBireysel.Text = "Bireysel";
            this.rdBireysel.UseVisualStyleBackColor = true;
            // 
            // rdTicari
            // 
            this.rdTicari.AutoSize = true;
            this.rdTicari.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTicari.Location = new System.Drawing.Point(243, 146);
            this.rdTicari.Margin = new System.Windows.Forms.Padding(2);
            this.rdTicari.Name = "rdTicari";
            this.rdTicari.Size = new System.Drawing.Size(76, 28);
            this.rdTicari.TabIndex = 10;
            this.rdTicari.TabStop = true;
            this.rdTicari.Text = "Ticari";
            this.rdTicari.UseVisualStyleBackColor = true;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Location = new System.Drawing.Point(137, 188);
            this.btnMusteriEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(155, 47);
            this.btnMusteriEkle.TabIndex = 11;
            this.btnMusteriEkle.Text = "MÜŞTERİ EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 250);
            this.dataGridView1.TabIndex = 12;
            // 
            // FormMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.rdTicari);
            this.Controls.Add(this.rdBireysel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblmusterino);
            this.Controls.Add(this.lblMno);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTckn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMusteriEkle";
            this.Text = "Müşteri Ekleme";
            this.Load += new System.EventHandler(this.FormMusteriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblMno;
        private System.Windows.Forms.Label lblmusterino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdBireysel;
        private System.Windows.Forms.RadioButton rdTicari;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
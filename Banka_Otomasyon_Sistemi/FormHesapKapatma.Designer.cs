namespace Banka_Otomasyon_Sistemi
{
    partial class FormHesapKapatma
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
            this.txtMusteriNoHK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHesapNoHK = new System.Windows.Forms.TextBox();
            this.txtHesapListe = new System.Windows.Forms.TextBox();
            this.btnHesapSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMusteriNoHK
            // 
            this.txtMusteriNoHK.Location = new System.Drawing.Point(256, 39);
            this.txtMusteriNoHK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriNoHK.Name = "txtMusteriNoHK";
            this.txtMusteriNoHK.Size = new System.Drawing.Size(230, 32);
            this.txtMusteriNoHK.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap Numarası : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHesapKapatma_Click);
            // 
            // txtHesapNoHK
            // 
            this.txtHesapNoHK.Location = new System.Drawing.Point(256, 315);
            this.txtHesapNoHK.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapNoHK.Name = "txtHesapNoHK";
            this.txtHesapNoHK.Size = new System.Drawing.Size(230, 32);
            this.txtHesapNoHK.TabIndex = 0;
            // 
            // txtHesapListe
            // 
            this.txtHesapListe.Location = new System.Drawing.Point(65, 94);
            this.txtHesapListe.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapListe.Multiline = true;
            this.txtHesapListe.Name = "txtHesapListe";
            this.txtHesapListe.Size = new System.Drawing.Size(538, 191);
            this.txtHesapListe.TabIndex = 0;
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.Location = new System.Drawing.Point(256, 387);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(230, 63);
            this.btnHesapSil.TabIndex = 3;
            this.btnHesapSil.Text = "HESAP SİL";
            this.btnHesapSil.UseVisualStyleBackColor = true;
            this.btnHesapSil.Click += new System.EventHandler(this.btnHesapSil_Click);
            // 
            // FormHesapKapatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 496);
            this.Controls.Add(this.btnHesapSil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHesapListe);
            this.Controls.Add(this.txtHesapNoHK);
            this.Controls.Add(this.txtMusteriNoHK);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormHesapKapatma";
            this.Text = "HESAP KAPATMA";
            this.Load += new System.EventHandler(this.FormHesapKapatma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriNoHK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHesapNoHK;
        private System.Windows.Forms.TextBox txtHesapListe;
        private System.Windows.Forms.Button btnHesapSil;
    }
}
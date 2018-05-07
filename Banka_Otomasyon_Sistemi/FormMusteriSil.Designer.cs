namespace Banka_Otomasyon_Sistemi
{
    partial class FormMusteriSil
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
            this.txtMuNo = new System.Windows.Forms.TextBox();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Numarası :";
            // 
            // txtMuNo
            // 
            this.txtMuNo.Location = new System.Drawing.Point(226, 37);
            this.txtMuNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMuNo.Name = "txtMuNo";
            this.txtMuNo.Size = new System.Drawing.Size(181, 22);
            this.txtMuNo.TabIndex = 1;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriSil.Location = new System.Drawing.Point(469, 29);
            this.btnMusteriSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(168, 39);
            this.btnMusteriSil.TabIndex = 2;
            this.btnMusteriSil.Text = "MÜŞTERİ SİL";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 259);
            this.dataGridView1.TabIndex = 3;
            // 
            // FormMusteriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 374);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.txtMuNo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMusteriSil";
            this.Text = "FormMusteriSil";
            this.Load += new System.EventHandler(this.FormMusteriSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMuNo;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
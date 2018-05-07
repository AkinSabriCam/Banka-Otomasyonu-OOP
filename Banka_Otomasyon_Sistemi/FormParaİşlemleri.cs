using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class FormParaİşlemleri : Form
    {
        
        public Banka banka;
        public FormParaİşlemleri()
        {
            InitializeComponent();
        }

        private void FormParaİşlemleri_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            txtListePI.Text = banka.HesapNoBulma(txtMusteriNoPI.Text);
        }
        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if(rdCekme.Checked==true)
            {    
                string MusteriNo = txtMusteriNoPI.Text;
                int HesapNo = Convert.ToInt32(txtHesapNoPI.Text);
                decimal Tutar =Convert.ToDecimal(txtTutarPI.Text);

                banka.ParaCekmeIslemi(MusteriNo,HesapNo,Tutar);
                txtListePI.Text = banka.HesapNoBulma(txtMusteriNoPI.Text);

            }
            else if(rdYatirma.Checked==true)
            {
                string MusteriNo = txtMusteriNoPI.Text;
                int HesapNo = Convert.ToInt32(txtHesapNoPI.Text);
                decimal Tutar = Convert.ToDecimal(txtTutarPI.Text);

                banka.ParaYatirmaİslemi(MusteriNo, HesapNo, Tutar);
                txtListePI.Text = banka.HesapNoBulma(txtMusteriNoPI.Text);
            }
            else if (rdHavale.Checked==true)
            {
                string MusteriNo = txtMusteriNoPI.Text;
                int HesapNo = Convert.ToInt32(txtHesapNoPI.Text);
                decimal Tutar =Convert.ToDecimal(txtTutarPI.Text);
                string MusteriNo2 = txtMusteriNo2PI.Text;
                int HesapNo2 = Convert.ToInt32(txtHesapNo2PI.Text);

                banka.ParaHavaleİslemi(HesapNo, HesapNo2, Tutar);
                txtListePI.Text = banka.HesapNoBulma(txtMusteriNoPI.Text);
            }
            else   MessageBox.Show("İşlem Seçiniz!");
                
        }

        private void rdHavale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHavale.Checked)
            {
                txtMusteriNo2PI.Enabled = true;
                txtHesapNo2PI.Enabled = true;
                lblMusteriNo.Enabled = true;
                lblHesNo.Enabled = true;
                btnBul2.Enabled = true;
            }
            else
            {
                txtMusteriNo2PI.Enabled = false;
                txtHesapNo2PI.Enabled = false;
                lblMusteriNo.Enabled = false;
                lblHesNo.Enabled = false;
                btnBul2.Enabled = false;
            }
        }

        private void btnBul2_Click(object sender, EventArgs e)
        {
            txtListePI.Text = banka.HesapNoBulma(txtMusteriNo2PI.Text);
        }

        
    }
}

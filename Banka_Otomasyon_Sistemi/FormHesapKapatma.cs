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
    public partial class FormHesapKapatma : Form
    {
        public Banka banka;
        public FormHesapKapatma()
        {
            InitializeComponent();
        }

        private void FormHesapKapatma_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnHesapKapatma_Click(object sender, EventArgs e)
        {
            txtHesapListe.Text=banka.HesapNoBulma(txtMusteriNoHK.Text);
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            banka.HesapSil(txtHesapNoHK.Text);
            txtHesapListe.Text = banka.HesapNoBulma(txtMusteriNoHK.Text);
        }
    }
}

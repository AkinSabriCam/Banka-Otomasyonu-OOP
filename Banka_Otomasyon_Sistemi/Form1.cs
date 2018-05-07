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
    public partial class Form1 : Form
    {
        public Banka banka;

        public Form1()
        {  
            InitializeComponent();
            banka = new Banka();
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = this.BackColor;
                }
            }  
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void yeniHesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormMusteriEkle me = new FormMusteriEkle();
            me.MdiParent = this;
            me.banka = this.banka;
            me.Show();
            
        }

        private void hesapKapatmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteriSil ms = new FormMusteriSil();
            ms.MdiParent = this;
            ms.banka = this.banka;
            ms.Show();

        }

        private void hesapİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void yeniHesapAçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormYeniHesapAç yh = new FormYeniHesapAç();
            yh.MdiParent = this;
            yh.banka = this.banka;
            yh.Show();
        }

        private void hesapKapatmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHesapKapatma hk = new FormHesapKapatma();
            hk.MdiParent = this;
            hk.banka = this.banka;
            hk.Show();
        }

        private void paraYatırÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParaİşlemleri pai = new FormParaİşlemleri();
            pai.MdiParent = this;
            pai.banka = this.banka;
            pai.Show();
        }

        private void hesapÖzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHesapOzeti ho = new FormHesapOzeti();
            ho.MdiParent = this;
            ho.banka = this.banka;
            ho.Show();
        }

        private void gelirGiderRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBankaGelirGiderRaporu ggr = new FormBankaGelirGiderRaporu();
            ggr.MdiParent = this;
            ggr.banka = this.banka;
            ggr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;    
        }

        private void hesapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

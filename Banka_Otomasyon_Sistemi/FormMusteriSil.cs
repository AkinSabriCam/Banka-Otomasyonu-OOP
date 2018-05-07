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
    public partial class FormMusteriSil : Form
    {
        public Banka banka;

        public FormMusteriSil()
        {
            InitializeComponent();
        }

        private void FormMusteriSil_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = banka.MusteriListele();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            banka.MusteriSil(txtMuNo.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = banka.MusteriListele();
        }
    }
}

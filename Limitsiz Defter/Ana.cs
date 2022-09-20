using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Limitsiz_Defter
{
    public partial class Ana : Form
    {
        public Ana()
        {
            InitializeComponent();
        }
        Birimekle brm = new Birimekle();
        odbirim odbrm = new odbirim();
        Musteriler musteriler = new Musteriler();
        Musteriekle musteriekle = new Musteriekle();
        Urunler urunler = new Urunler();
        Urunekle urunekle = new Urunekle();
        Gelir gelir = new Gelir();
        Gider gider = new Gider();
        Kasa kasa = new Kasa();
        Fatura fatura = new Fatura();
        Caristok caristok = new Caristok();

        private void Ana_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatlbl.Text = System.DateTime.Now.ToString();
        }

        private void musterilerpb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            musteriler.ShowDialog();
            this.Visible = true;
        }

        private void musterilerlbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            musteriler.ShowDialog();
            this.Visible = true;
        }

        private void msuterieklepb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            musteriekle.ShowDialog();
            this.Visible = true;
        }

        private void msuterieklelbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            musteriekle.ShowDialog();
            this.Visible = true;
        }

        private void urunlerpb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            urunler.ShowDialog();
            this.Visible = true;
        }

        private void urunlerlbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            urunler.ShowDialog();
            this.Visible = true;
        }

        private void uruneklepb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            urunekle.ShowDialog();
            this.Visible = true;
        }

        private void uruneklelbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            urunekle.ShowDialog();
            this.Visible = true;
        }

        private void gelirpb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gelir.ShowDialog();
            this.Visible = true;
        }

        private void gelirlbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gelir.ShowDialog();
            this.Visible = true;
        }

        private void giderpb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gider.ShowDialog();
            this.Visible = true;
        }

        private void giderlbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gider.ShowDialog();
            this.Visible = true;
        }

        private void kasapb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            kasa.ShowDialog();
            this.Visible = true;
        }

        private void kasalbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            kasa.ShowDialog();
            this.Visible = true;
        }

        private void faturapb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            fatura.ShowDialog();
            this.Visible = true;
        }

        private void faturalbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            fatura.ShowDialog();
            this.Visible = true;
        }

        private void şifreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BirimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            brm.ShowDialog();
            this.Show();
        }

        private void CariBakiyeRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            caristok.ShowDialog();
            this.Show();
        }

        private void ödemeBirimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            odbrm.ShowDialog();
            this.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

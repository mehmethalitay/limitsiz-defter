using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Limitsiz_Defter
{
    public partial class Urunekle : Form
    {
        public Urunekle()
        {
            InitializeComponent();
        }
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        private void Ukaydetpb_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed) baglan.Open();
                SQLiteCommand con = new SQLiteCommand("Insert Into urunler(kod,birim,urunadi,maliyet,stok,satis) values (@kod,@birim,@urunadi,@maliyet,@stok,@satis)", baglan);
                con.Parameters.AddWithValue("@kod", ukodrtb.Text);
                con.Parameters.AddWithValue("@birim", ubirimcb.Text);
                con.Parameters.AddWithValue("@urunadi", uadirtb.Text);
                con.Parameters.AddWithValue("@maliyet", umaliyetrtb.Text);
                con.Parameters.AddWithValue("@stok", ustokrtb.Text);
                con.Parameters.AddWithValue("@satis", usatisrtb.Text);
                con.ExecuteNonQuery();
                foreach (Control item in this.Controls)
                {
                    if (item is RichTextBox)
                    {
                        RichTextBox tbox = (RichTextBox)item;
                        tbox.Clear();
                    }
                }//Temizlik Görevlisi
                baglan.Close();
                MessageBox.Show("Ürün Başarı ile Eklendi");

            }
            catch (Exception sa)
            {
                MessageBox.Show("Hata Program yöneticileriyle iletişime geçin \n" + sa.ToString());
            }

        }
        void birimgetir()
        {
            try
            {
                ubirimcb.Items.Clear();
                if (baglan.State != ConnectionState.Open) baglan.Open();
                SQLiteCommand cmd = new SQLiteCommand("Select * From birim", baglan);
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) //while’i tüm öğeleri seçmek için kullandık.
                {
                    
                    ubirimcb.Items.Add(dr["birimadi"]);//verileri listboxa ekliyoruz .
                }
            }
            catch (Exception sa)
            {
                MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
            }

        }
        private void Urunekle_Load(object sender, EventArgs e)
        {
            birimgetir();
        }

        private void uiptalpb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ustokrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}

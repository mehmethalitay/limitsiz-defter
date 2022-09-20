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
    public partial class Gider : Form
    {
        public Gider()
        {
            InitializeComponent();
        }
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        
        private void Gkaydetpb_Click(object sender, EventArgs e)
        {
            double gider =-1*Convert.ToDouble(gtutarrtb.Text);
            DateTime dt =Convert.ToDateTime(gtarihidtp.Value);
            try
            {
                baglan.Close();
                baglan.Open();
                SQLiteCommand con = new SQLiteCommand("Insert Into kasa(tur,tarih,kaynak,aciklama,tutar,mid) values (@tur,@tarih,@kaynak,@aciklama,@tutar,@mid)", baglan);
                con.Parameters.AddWithValue("@tur", gturucb.Text);
                con.Parameters.AddWithValue("@tarih",dt);
                con.Parameters.AddWithValue("@kaynak", "-1");
                con.Parameters.AddWithValue("@aciklama", gaciklamartb.Text);
                con.Parameters.AddWithValue("@tutar", gider);
                con.Parameters.AddWithValue("@mid", "-1");
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
                MessageBox.Show("Gelir Girildi");
            }
            catch (Exception sa)
            {
                MessageBox.Show("Hata Program yöneticileriyle iletişime geçin \n" + sa.ToString());
            }
        }

        private void Gider_Load(object sender, EventArgs e)
        {
            gturucb.Items.Clear();
            birimgetir();
        }

        void birimgetir()
        {
            try
            {

                if (baglan.State != ConnectionState.Open) baglan.Open();
                SQLiteCommand cmd = new SQLiteCommand("Select * From odbirim", baglan);
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) //while’i tüm öğeleri seçmek için kullandık.
                {
                    gturucb.Items.Add(dr["odbirim"]);//verileri listboxa ekliyoruz .
                }
            }
            catch (Exception sa)
            {
                MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
            }

        }

        private void gtutarrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}

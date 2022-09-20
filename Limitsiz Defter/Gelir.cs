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
    public partial class Gelir : Form
    {
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        public Gelir()
        {
            InitializeComponent();
        }
        string gelenmusterid="-1", gelenmusteriadi="-1";
        public Gelir(string mid,string musteriadi)
        {
            InitializeComponent();
            this.gelenmusteriadi = musteriadi;
            this.gelenmusterid = mid;
        }
        private void Gelir_Load(object sender, EventArgs e)
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

        private void Gkaydetpb_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(gtarihidtp.Value);
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SQLiteCommand con = new SQLiteCommand("Insert Into kasa(tur,tarih,kaynak,aciklama,tutar,mid) values (@tur,@tarih,@kaynak,@aciklama,@tutar,@mid)", baglan);
                con.Parameters.AddWithValue("@tur", gturucb.Text);
                con.Parameters.AddWithValue("@tarih", dt);
                con.Parameters.AddWithValue("@kaynak", gelenmusteriadi);
                con.Parameters.AddWithValue("@aciklama", gaciklamartb.Text);
                con.Parameters.AddWithValue("@tutar", gtutarrtb.Text);
                con.Parameters.AddWithValue("@mid", gelenmusterid);
                con.ExecuteNonQuery();

                SQLiteCommand con4 = new SQLiteCommand("Select * From musteriler where id ='" + gelenmusterid + "'", baglan);
                SQLiteDataReader dr = con4.ExecuteReader();
                if (dr.Read())
                {
                    double malinan, mbakiye, nalinan, nbakiye;

                    malinan = Convert.ToDouble(dr["alinan"]);
                    mbakiye = Convert.ToDouble(dr["bakiye"]);
                    
                    nalinan = Convert.ToDouble(gtutarrtb.Text);


                    SQLiteCommand con5 = new SQLiteCommand("Update musteriler set alinan = @nalinan, bakiye = @nbakiye where id = '" + gelenmusterid + "' ", baglan);

                    double sonuc, sonuc1;
                    sonuc=mbakiye - nalinan;
                    sonuc = Math.Round(sonuc, 2);
                    sonuc1 = malinan + nalinan;
                    sonuc1 = Math.Round(sonuc1, 2);

                    con5.Parameters.AddWithValue("@nalinan", sonuc1);
                    con5.Parameters.AddWithValue("@nbakiye", sonuc);
                    con5.ExecuteNonQuery();
                    baglan.Close();

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
            }
            catch (Exception sa)
            {
                MessageBox.Show("Hata Program yöneticileriyle iletişime geçin \n" + sa.ToString());
            }

        }
    }
}

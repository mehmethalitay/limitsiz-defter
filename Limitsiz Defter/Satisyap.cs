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
    public partial class Satisyap : Form
    {
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        string idgetir;
        
        public Satisyap(string idget,string adsoyad,string telfon,string firma,string mail)
        {
            InitializeComponent();
            sadsoyadrtb.Text = adsoyad;
            stelefonrtb.Text = telfon;
            sfirmartb.Text = firma;
            smailrtb.Text = mail;
            idgetir = idget; 

        }

        private void Satisyap_Load(object sender, EventArgs e)
        {
            susterilerdtgw.ColumnCount = 10;
            susterilerdtgw.Columns[0].Name = "kod";
            susterilerdtgw.Columns[1].Name = "birim";
            susterilerdtgw.Columns[2].Name = "urunadi";
            susterilerdtgw.Columns[3].Name = "maliyet";
            susterilerdtgw.Columns[4].Name = "stok";
            susterilerdtgw.Columns[5].Name = "birimadet";
            susterilerdtgw.Columns[6].Name = "satis";
            susterilerdtgw.Columns[7].Name = "isk";
            susterilerdtgw.Columns[8].Name = "kdv";
            susterilerdtgw.Columns[9].Name = "topsatis";

            stoplamrtb.Enabled = false;
            skalanrtb.Enabled = false;

        }
       
        private void Surunpb_Click(object sender, EventArgs e)
        {
            
            Urunler urunler = new Urunler(true);
            
            if (urunler.ShowDialog()== DialogResult.OK)
            {
                aktar akt = new aktar();
                susterilerdtgw.Rows.Add(urunler.kod, urunler.birim,  urunler.urunadi, urunler.maliyet, urunler.stok, urunler.adet, urunler.satis, urunler.isk, urunler.kdv );
                hesaplama();
            }


        }



        private void Skaydetpb_Click(object sender, EventArgs e)
        {
            if (susterilerdtgw.SelectedRows.Count>0)
            {
                try
                {
                    double stok, cstok, stoksonuc;

                    if (baglan.State == ConnectionState.Closed)
                        baglan.Open();

                    DateTime dt = Convert.ToDateTime(starihidtp.Value);
                    SQLiteCommand con = new SQLiteCommand("Insert Into kasa(tur,tarih,kaynak,aciklama,tutar,mid) values (@tur,@tarih,@kaynak,@aciklama,@tutar,@mid)", baglan);
                    con.Parameters.AddWithValue("@tur", "bakiye");
                    con.Parameters.AddWithValue("@tarih", dt);
                    con.Parameters.AddWithValue("@kaynak", sadsoyadrtb.Text);
                    con.Parameters.AddWithValue("@aciklama", "müşteriye satış");
                    con.Parameters.AddWithValue("@tutar", stoplamrtb.Text);
                    con.Parameters.AddWithValue("@mid", idgetir);
                    con.ExecuteNonQuery();


                    for (int i = 0; i < susterilerdtgw.RowCount; i++)
                    {
                        SQLiteCommand con2 = new SQLiteCommand("Insert Into fatura(tarih,musteri,kod,urun,birim,birimadet,tutar,bakiye,mid) values (@tarih,@musteri,@kod,@urun,@birim,@birimadet,@tutar,@bakiye,@mid)", baglan);

                        con2.Parameters.AddWithValue("@tarih", dt);
                        con2.Parameters.AddWithValue("@musteri", sadsoyadrtb.Text);
                        con2.Parameters.AddWithValue("@kod", susterilerdtgw.Rows[i].Cells[0].Value);
                        con2.Parameters.AddWithValue("@urun", susterilerdtgw.Rows[i].Cells[3].Value);
                        con2.Parameters.AddWithValue("@birim", susterilerdtgw.Rows[i].Cells[1].Value);
                        con2.Parameters.AddWithValue("@birimadet", susterilerdtgw.Rows[i].Cells[5].Value);
                        con2.Parameters.AddWithValue("@tutar", stoplamrtb.Text);
                        con2.Parameters.AddWithValue("@bakiye", skalanrtb.Text);
                        con2.Parameters.AddWithValue("@mid", idgetir);
                        con2.ExecuteNonQuery();


                        stok = Convert.ToDouble(susterilerdtgw.Rows[i].Cells[4].Value);
                        cstok = Convert.ToDouble(susterilerdtgw.Rows[i].Cells[5].Value);
                        stoksonuc = stok - cstok;

                        SQLiteCommand con3 = new SQLiteCommand("Update urunler set stok = @nstok where kod = @kod ", baglan);

                        con3.Parameters.AddWithValue("@nstok", stoksonuc);
                        con3.Parameters.AddWithValue("@kod", susterilerdtgw.Rows[i].Cells[0].Value);
                        con3.ExecuteNonQuery();



                    }
                    SQLiteCommand con4 = new SQLiteCommand("Select * From musteriler where id ='" + idgetir + "'", baglan);
                    SQLiteDataReader dr = con4.ExecuteReader();
                    if (dr.Read())
                    {
                        double mtoplam, malinan, mbakiye, ntoplam, nalinan, nbakiye;
                        mtoplam = Convert.ToDouble(dr["toplam"]);
                        malinan = Convert.ToDouble(dr["alinan"]);
                        mbakiye = Convert.ToDouble(dr["bakiye"]);

                        ntoplam = Convert.ToDouble(stoplamrtb.Text);
                        nalinan = Convert.ToDouble(salinanrtb.Text);
                        nbakiye = Convert.ToDouble(skalanrtb.Text);

                        SQLiteCommand con5 = new SQLiteCommand("Update musteriler set toplam = @ntoplam, alinan = @nalinan, bakiye = @nbakiye where id = '" + idgetir + "' ", baglan);
                        con5.Parameters.AddWithValue("@ntoplam", mtoplam + ntoplam);
                        con5.Parameters.AddWithValue("@nalinan", malinan + nalinan);
                        con5.Parameters.AddWithValue("@nbakiye", mbakiye + nbakiye);
                        con5.ExecuteNonQuery();
                        baglan.Close();

                    }
                    this.Close();
                }
                catch (Exception)
                {
                    baglan.Close();
                    msgbx msgbox1 = new msgbx(msgbx.Durum.hata, "Boş Satış Yapılamaz!");
                    msgbox1.ShowDialog();

                }

            }
            else
            {
                msgbx msgbox = new msgbx(msgbx.Durum.hata, "Boş Satış Yapılamaz!");
                msgbox.ShowDialog();
            } 

        }

        private void Salinanrtb_TextChanged(object sender, EventArgs e)
        {
            if (salinanrtb.Text.Length <= 0)
            salinanrtb.Text = "0"; 
            double toplam =Convert.ToDouble(stoplamrtb.Text);
            double alinan =Convert.ToDouble(salinanrtb.Text);
            double sonuc = toplam - alinan;
            sonuc = Math.Round(sonuc, 2);
            skalanrtb.Text = sonuc.ToString();
        }

        
        void hesaplama()
        {
            double geneltoplam = 0;
            for (int i = 0; i < susterilerdtgw.RowCount; i++)
            {
                double satistop,isktop,kdvtop;
                satistop = Convert.ToDouble(susterilerdtgw.Rows[i].Cells[6].Value)* (Convert.ToDouble(susterilerdtgw.Rows[i].Cells[5].Value));
                isktop = satistop - (satistop * Convert.ToDouble(susterilerdtgw.Rows[i].Cells[7].Value) /100);
                kdvtop = isktop + (isktop * Convert.ToDouble(susterilerdtgw.Rows[i].Cells[8].Value) / 100);
                susterilerdtgw.Rows[i].Cells[9].Value = kdvtop.ToString();
                geneltoplam += Convert.ToDouble(susterilerdtgw.Rows[i].Cells[9].Value);
            }
            stoplamrtb.Text = geneltoplam.ToString();
        }

        private void Susterilerdtgw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                MessageBox.Show("enter");
                hesaplama();
            }
        }

        private void Susterilerdtgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stoplamrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void salınanrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!=',';
        }

        private void skalanrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ssilpb_Click(object sender, EventArgs e)
        {          
            int selectedIndex = susterilerdtgw.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    susterilerdtgw.Rows.RemoveAt(selectedIndex);
                    hesaplama();
                    susterilerdtgw.Refresh();
            }
        }

        private void siptalpb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

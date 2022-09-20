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
    public partial class Musteriekle : Form
    {
        public Musteriekle()
        {
            InitializeComponent();
        }
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        private void Mkaydetpb_Click(object sender, EventArgs e)
        {
            if (madsoyadrtb.Text.Length > 0 && mfirmartb.Text.Length > 0)
            {
                try
                {
                    baglan.Open();
                    SQLiteCommand con = new SQLiteCommand("Insert Into musteriler(adsoyad,telefon,adres,firma,mail) values (@adsoyad,@telefon,@adres,@firma,@mail)", baglan);
                    con.Parameters.AddWithValue("@adsoyad", madsoyadrtb.Text);
                    con.Parameters.AddWithValue("@telefon", mtelefonrtb.Text);
                    con.Parameters.AddWithValue("@adres", madresrtb.Text);
                    con.Parameters.AddWithValue("@firma", mfirmartb.Text);
                    con.Parameters.AddWithValue("@mail", mmailrtb.Text);
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
                    msgbx msgbox = new msgbx(msgbx.Durum.basari, 5, "Müşteri Başarı ile Eklendi");
                    msgbox.ShowDialog();

                }
                catch (Exception sa)
                {
                    msgbx msgbox = new msgbx(msgbx.Durum.hata, "Hata Program yöneticileriyle iletişime geçin \n" + sa.ToString());
                    msgbox.ShowDialog();
                }
            }
            else
            {
                msgbx msgbox = new msgbx(msgbx.Durum.hata, "Gerekli Yerleri Doldurunuz!");
                msgbox.ShowDialog();
            }
            

        }

        private void miptalpb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

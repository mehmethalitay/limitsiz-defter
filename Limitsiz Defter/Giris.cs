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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        Ana ana = new Ana();
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        SQLiteCommand command;
        private void Giris_Load(object sender, EventArgs e)
        {
            
        }

        void GetOpen()
        {

            try
            {
                baglan.Open();
                command = new SQLiteCommand("Select * From kullanici WHERE kullaniciadi=@kadi AND sifre=@sif", baglan);
                command.Parameters.AddWithValue("@kadi", kullanicirtb.Text);
                command.Parameters.AddWithValue("@sif", sifrertb.Text);
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            TextBox tbox = (TextBox)item;
                            tbox.Clear();
                        }
                    }
                    msgbx msgbox = new msgbx(msgbx.Durum.basari, 5, "Giriş Yapıldı Yönlendiriliyorsunuz.");
                    msgbox.ShowDialog();
                    this.Visible = false;
                    ana.ShowDialog();
                    this.Close();
                }
                else
                {
                    msgbx msgbox = new msgbx(msgbx.Durum.hata, "Kullanıcı Veya Sifreniz Hatalı!");
                    msgbox.ShowDialog();
                }
                baglan.Close();

            }
            catch (Exception sa)
            {
                MessageBox.Show("LÜTFEN PROGRAM DAGITICISIYLA İLETİŞİME GEÇİN \n" + sa.ToString());
            }

        }

        private void girispb_Click(object sender, EventArgs e)
        {
            GetOpen();
        }

        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetOpen();
            }
        }

        private void cikispb_Click(object sender, EventArgs e)
        {
            msgbx msgbox1 = new msgbx(msgbx.Durum.soru, "Çıkış yapmak istiyormusunuz ?", msgbx.Butonlar.evethayir);
            DialogResult kaydet = msgbox1.ShowDialog();
            if (kaydet == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

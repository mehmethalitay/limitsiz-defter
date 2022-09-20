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
    public partial class odbirim : Form
    {
        public odbirim()
        {
            InitializeComponent();
        }

        SQLiteCommand cmd;
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        void birimgetir1()
        {
            try
            {
                bbirmlerlb.Items.Clear();
                if (baglan.State != ConnectionState.Open) baglan.Open();
                SQLiteCommand cmd = new SQLiteCommand("Select * From odbirim", baglan);
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bbirmlerlb.Items.Add(dr["odbirim"]);
                }
            }
            catch (Exception sa)
            {
                MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
            }

        }

        private void biptalpb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bsilpb_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State != ConnectionState.Open) baglan.Open();
                cmd = new SQLiteCommand("Delete From odbirim where odbirim='" + bbirmlerlb.SelectedItem.ToString() + "'", baglan);
                cmd.ExecuteNonQuery();
                baglan.Close();
                birimgetir1();

            }
            catch (Exception sa)
            {
                MessageBox.Show("Lütfen Program Sağlayıcınızla Görüşün \n" + sa.ToString());
            }
        }

        private void bkaydetpb_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State != ConnectionState.Open) baglan.Open();
                SQLiteCommand con = new SQLiteCommand("Insert Into odbirim(odbirim) values (@odbirim)", baglan);
                con.Parameters.AddWithValue("@odbirim", gtutarrtb.Text);
                con.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Birim Başarı ile Eklendi");

            }
            catch (Exception sa)
            {
                MessageBox.Show("Hata Program yöneticileriyle iletişime geçin \n" + sa.ToString());
            }
            birimgetir1();
            gtutarrtb.Text = "";
        }

        private void odbirim_Load(object sender, EventArgs e)
        {
            birimgetir1();
        }
    }
}

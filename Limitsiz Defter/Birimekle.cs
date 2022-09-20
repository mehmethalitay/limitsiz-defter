using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Limitsiz_Defter
{
    public partial class Birimekle : Form
    {
        public Birimekle()
        {
            InitializeComponent();
        }

        SQLiteCommand cmd;
        void birimgetir()
        {
            try
            {
                bbirmlerlb.Items.Clear();
                if (baglan.State != ConnectionState.Open) baglan.Open();
                SQLiteCommand cmd = new SQLiteCommand("Select * From birim", baglan);
                SQLiteDataReader dr=cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    bbirmlerlb.Items.Add(dr["birimadi"]);
                }
            }
            catch (Exception sa)
            {
                MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
            }

        }
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        private void Bkaydetpb_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State != ConnectionState.Open) baglan.Open();
                SQLiteCommand con = new SQLiteCommand("Insert Into birim(birimadi) values (@birimadi)", baglan);
                con.Parameters.AddWithValue("@birimadi", gtutarrtb.Text);
                con.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Birim Başarı ile Eklendi");

            }
            catch (Exception sa)
            {
                MessageBox.Show("Hata Program yöneticileriyle iletişime geçin \n" + sa.ToString());
            }
            birimgetir();
            gtutarrtb.Text = "";
        }

        private void Birimekle_Load(object sender, EventArgs e)
        {
            birimgetir();
        }

        private void Bsilpb_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State != ConnectionState.Open) baglan.Open();
                cmd = new SQLiteCommand("Delete From birim where birimadi='" + bbirmlerlb.SelectedItem.ToString() + "'", baglan);
                cmd.ExecuteNonQuery();
                baglan.Close();
                birimgetir();

            }
            catch (Exception sa)
            {
                MessageBox.Show("Lütfen Program Sağlayıcınızla Görüşün \n" + sa.ToString());
            }
        }

        private void biptalpb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
